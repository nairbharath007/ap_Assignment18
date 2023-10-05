using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppCohesive.Model
{
    internal class Inventory
    {
        private List<Instrument> inventory;

        public Inventory()
        {
            inventory = new List<Instrument>();
        }

        public void AddInstrument(string serialNumber, double price, InstrumentSpec spec)
        {
            Instrument instrument = new Instrument(serialNumber, price, spec);
            inventory.Add(instrument);
        }

        public Instrument Get(string serialNumber)
        {
            return inventory.FirstOrDefault(instrument => instrument.GetSerialNumber().Equals(serialNumber));
        }

        public List<Instrument> Search(InstrumentSpec searchSpec)
        {
            return inventory.Where(instrument => instrument.GetSpec().Matches(searchSpec)).ToList();
        }
    }

}

