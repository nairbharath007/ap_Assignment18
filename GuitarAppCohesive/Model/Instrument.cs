using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppCohesive.Model
{
    internal class Instrument
    {

        private string serialNumber;
        private double price;
        private InstrumentSpec spec;

        public Instrument(string serialNumber, double price, InstrumentSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

        public string GetSerialNumber()
        {
            return serialNumber;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double newPrice)
        {
            this.price = newPrice;
        }

        public InstrumentSpec GetSpec()
        {
            return spec;
        }
    }

}

