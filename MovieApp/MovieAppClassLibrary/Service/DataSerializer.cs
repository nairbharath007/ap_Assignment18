using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppClassLibrary.Service
{
    internal class DataSerializer
    {
        public static void BinarySerializer(string filePath, List<Movie> movies)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, movies);
                }
            }
            catch (Exception ex)
            {
                throw new SerializationException("Failed to serialize movies: " + ex.Message);
            }

        }

        public static List<Movie> BinaryDeserializer(string filePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (List<Movie>)formatter.Deserialize(fileStream);
                }
            }
            catch (FileNotFoundException)
            {
                return null;
            }
            catch (Exception ex)
            {
                throw new SerializationException("Failed to deserialize movies: " + ex.Message);
            }

            return new List<Movie>();
        }
    }
}
