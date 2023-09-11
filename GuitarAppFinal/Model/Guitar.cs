using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppFinal.Model
{
    internal class Guitar
    {
        private string serialNumber;
        private double price;
        public GuitarSpec spec;

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

        public string SerialNumber
        {
            get { return serialNumber; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public GuitarSpec Spec
        {
            get { return spec; }
        }
    }
}
