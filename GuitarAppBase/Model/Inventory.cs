using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppBase.Model
{
    internal class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price,
                              string builder, string model,
                              string type, string backWood, string topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder,
                                       model, type, backWood, topWood);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (Guitar guitar in guitars)
            {
                if (guitar.SerialNumber.Equals(serialNumber, StringComparison.OrdinalIgnoreCase))
                {
                    return guitar;
                }
            }
            return null;
        }

        public Guitar Search(Guitar searchGuitar)
        {
            foreach (Guitar guitar in guitars)
            {
                // Ignore serial number since that's unique
                // Ignore price since that's unique
                string builder = searchGuitar.Builder;
                if (!string.IsNullOrEmpty(builder) && !string.Equals(builder, guitar.Builder, StringComparison.OrdinalIgnoreCase))
                    continue;

                string model = searchGuitar.Model;
                if (!string.IsNullOrEmpty(model) && !string.Equals(model, guitar.Model, StringComparison.OrdinalIgnoreCase))
                    continue;

                string type = searchGuitar.Type;
                if (!string.IsNullOrEmpty(type) && !string.Equals(type, guitar.Type, StringComparison.OrdinalIgnoreCase))
                    continue;

                string backWood = searchGuitar.BackWood;
                if (!string.IsNullOrEmpty(backWood) && !string.Equals(backWood, guitar.BackWood, StringComparison.OrdinalIgnoreCase))
                    continue;

                string topWood = searchGuitar.TopWood;
                if (!string.IsNullOrEmpty(topWood) && !string.Equals(topWood, guitar.TopWood, StringComparison.OrdinalIgnoreCase))
                    continue;

                return guitar;
            }
            return null;
        }
    }
}

