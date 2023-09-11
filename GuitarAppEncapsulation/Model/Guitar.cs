using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppEncapsulation.Model
{
    internal class Guitar
    {
        private string serialNumber;
        private double price;
        GuitarSpec spec;

        public Guitar(string serialNumber, double price,
            Builder builder, string model, Type type,
            Wood backWood, Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = new GuitarSpec(builder, model, type, backWood, topWood);
        }

        public string GetSerialNumber()
        {
            return serialNumber;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(float newPrice)
        {
            this.price = newPrice;
        }

        public GuitarSpec GetSpec()
        {
            return spec;
        }
    }
}
