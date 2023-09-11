using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppEncapsulation.Model
{
    internal class GuitarSpec
    {
        private Builder builder;
        private string model;
        private Type type;
        private Wood backWood;
        private Wood topWood;

        public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }

        public Builder GetBuilder()
        {
            return builder;
        }

        public string GetModel()
        {
            return model;
        }

        public Type GetType()
        {
            return type;
        }

        public Wood GetBackWood()
        {
            return backWood;
        }

        public Wood GetTopWood()
        {
            return topWood;
        }

    }
}
