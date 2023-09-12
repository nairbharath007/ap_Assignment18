using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GuitarApp.Model
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
                /*string builder = searchGuitar.Builder;
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
                    continue;*/


                if (searchGuitar.Builder != guitar.Builder)
                    continue;

                /*string model = searchGuitar.Model.ToLower();
                if ((model != null) && (!model.Equals("")) && 
                    (!model.Equals(guitar.Model.ToLower())))
                        continue;*/
                string model = searchGuitar.Model.ToLower();
                //string model2 = guitar.Model.ToLower();
                if (!string.IsNullOrEmpty(model) &&
                    !string.Equals(model, guitar.Model.ToLower()))
                    continue;

                if (searchGuitar.Type != guitar.Type)
                    continue;
                if (searchGuitar.BackWood != guitar.BackWood)
                    continue;
                if(searchGuitar.TopWood != guitar.TopWood)
                    continue;

                return guitar;
            }
            return null;
        }
    }

}
