using MovieStoreListSerialize.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreListSerialize.Model
{
    internal class MovieController
    {
        private MovieManager manager;

        public MovieController()
        {
            manager = new MovieManager();
        }

        public void Start()
        {
            LoadMoviesFromDataFile();

            while (true)
            {
                DisplayMenu();
                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        DisplayAllMovies();
                        break;
                    case 2:
                        AddMovie();
                        break;
                    case 3:
                        FindMoviesByYear();
                        break;
                    case 4:
                        RemoveMovieByName();
                        break;
                    case 5:
                        ClearMovieList();
                        break;
                    case 6:
                        SaveMoviesToDataFile();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void LoadMoviesFromDataFile()
        {
            manager.DeserializeMovies();
            Console.WriteLine("Movies loaded from file.");
        }

        private void SaveMoviesToDataFile()
        {
            manager.SerializeMovies();
            Console.WriteLine("Movies saved to file.");
        }

        private void DisplayAllMovies()
        {
            Console.WriteLine(manager.GetMoviesFormatted());
        }

        private void AddMovie()
        {
            Movie newMovie = SetMovieDetails();
            if (newMovie != null)
            {
                bool addedSuccessfully = manager.AddMovie(newMovie);
                if (addedSuccessfully)
                {
                    Console.WriteLine("Movie added successfully!");
                }
                else
                {
                    Console.WriteLine("The movie list is full (maximum 5 movies).");
                }
            }
        }

        private void FindMoviesByYear()
        {
            Console.Write("Enter the year to find movies: ");
            if (int.TryParse(Console.ReadLine(), out int searchYear))
            {
                List<Movie> moviesByYear = manager.FindMoviesByYear(searchYear);
                Console.WriteLine(manager.GetMoviesFormatted(moviesByYear));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
            }
        }

        private void RemoveMovieByName()
        {
            Console.Write("Enter the name of the movie to remove: ");
            string movieName = Console.ReadLine();
            manager.RemoveMovieByName(movieName);
            Console.WriteLine($"Movie '{movieName}' removed successfully!");
        }

        private void ClearMovieList()
        {
            manager.ClearList();
            Console.WriteLine("All movies removed from the store.");
        }

        private Movie SetMovieDetails()
        {
            if (manager.GetAllMovies().Count >= 5)
            {
                //throw new MovieStoreException("The movie list is full (maximum 5 movies).");
                Console.WriteLine("The movie list is full (maximum 5 movies).");
                return null;

            }

            try
            {
                Console.Write("Enter Movie ID: ");
                int movieId = int.Parse(Console.ReadLine());

                Console.Write("Enter Movie Name: ");
                string movieName = Console.ReadLine();

                if (manager.GetAllMovies().Exists(m => m.MovieId == movieId || m.MovieName == movieName))
                {
                    throw new DuplicateMovieException("A movie with the same ID or Name already exists.");
                }

                Console.Write("Enter Year: ");
                int year = int.Parse(Console.ReadLine());

                if (year < 0)
                {
                    throw new InvalidYearException("Invalid year entered.");
                }

                Console.Write("Enter Director: ");
                string director = Console.ReadLine();

                return new Movie(movieId, movieName, year, director);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid data.");
                return null;
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("\nMovie Store Menu");
            Console.WriteLine("1. Display all movies");
            Console.WriteLine("2. Add a movie");
            Console.WriteLine("3. Find a movie by year");
            Console.WriteLine("4. Remove a movie by name");
            Console.WriteLine("5. Clear the list");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
        }
    }
}
