using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuitarAppChoices.Model
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price,
                              Builder builder, string model,
                              Type type, Wood backWood, Wood topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder,
                                       model, type, backWood, topWood);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            return guitars.FirstOrDefault(guitar => guitar.SerialNumber.Equals(serialNumber, StringComparison.OrdinalIgnoreCase));
        }

        public List<Guitar> Search(Guitar searchGuitar)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in guitars)
            {
                // Ignore serial number since that's unique
                // Ignore price since that's unique
                if (searchGuitar.Builder != guitar.Builder)
                    continue;

                string model = searchGuitar.Model.ToLower();
                if (!string.IsNullOrEmpty(model) &&
                    !string.Equals(model, guitar.Model, StringComparison.OrdinalIgnoreCase))
                    continue;

                if (searchGuitar.Type != guitar.Type)
                    continue;

                if (searchGuitar.BackWood != guitar.BackWood)
                    continue;

                if (searchGuitar.TopWood != guitar.TopWood)
                    continue;

                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }


}
