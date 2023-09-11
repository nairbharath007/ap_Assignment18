using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppFinal.Model
{
    internal class GuitarSpec
    {
        public Builder builder;
        public string model;
        public Type type;
        public int numStrings;
        public Wood backWood;
        public Wood topWood;

        public GuitarSpec(Builder builder, string model, Type type,
            int numStrings, Wood backWood, Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.numStrings = numStrings;
            this.backWood = backWood;
            this.topWood = topWood;
        }

        public bool Matches(GuitarSpec otherSpec)
        {
            if (builder != otherSpec.builder)
                return false;
            if (!string.IsNullOrEmpty(model) && !model.Equals(otherSpec.model, StringComparison.OrdinalIgnoreCase))
                return false;
            if (type != otherSpec.type)
                return false;
            if (numStrings != otherSpec.numStrings)
                return false;
            if (backWood != otherSpec.backWood)
                return false;
            if (topWood != otherSpec.topWood)
                return false;
            return true;
        }
    }
}
