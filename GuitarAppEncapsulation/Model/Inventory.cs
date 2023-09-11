using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppEncapsulation.Model
{
    internal class Inventory
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
                if (guitar.GetSerialNumber() == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in guitars)
            {
                GuitarSpec guitarSpec = guitar.GetSpec();
                if (searchSpec.GetBuilder() != guitarSpec.GetBuilder())
                    continue;
                string model = searchSpec.GetModel().ToLower();
                if (!string.IsNullOrEmpty(model) && model != guitarSpec.GetModel().ToLower())
                    continue;
                if (searchSpec.GetType() != guitarSpec.GetType())
                    continue;
                if (searchSpec.GetBackWood() != guitarSpec.GetBackWood())
                    continue;
                if (searchSpec.GetTopWood() != guitarSpec.GetTopWood())
                    continue;
                matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
