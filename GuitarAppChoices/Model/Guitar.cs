using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppChoices.Model
{
    public class Guitar
    {
        private string serialNumber, model;
        private double price;
        private Builder builder;
        private Type type;
        private Wood backWood, topWood;

        public Guitar(string serialNumber, double price,
                      Builder builder, string model, Type type,
                      Wood backWood, Wood topWood)
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
            //set { price = value; }
        }

        public Builder Builder
        {
            get { return builder; }
        }

        public string Model
        {
            get { return model; }
        }

        public Type Type
        {
            get { return type; }
        }

        public Wood BackWood
        {
            get { return backWood; }
        }

        public Wood TopWood
        {
            get { return topWood; }
        }
    }


}
