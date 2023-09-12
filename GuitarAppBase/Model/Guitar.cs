using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppBase.Model
{
    internal class Guitar
    {
        private string serialNumber, builder, model, type, backWood, topWood;
        private double price;

        public Guitar(string serialNumber, double price,
                      string builder, string model, string type,
                      string backWood, string topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
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

        public string Builder
        {
            get { return builder; }
        }

        public string Model
        {
            get { return model; }
        }

        public string Type
        {
            get { return type; }
        }

        public string BackWood
        {
            get { return backWood; }
        }

        public string TopWood
        {
            get { return topWood; }
        }
    }
}

