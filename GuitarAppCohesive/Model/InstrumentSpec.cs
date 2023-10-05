using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppCohesive.Model
{
    internal class InstrumentSpec
    {
        private Dictionary<string, object> properties;

        public InstrumentSpec(Dictionary<string, object> properties)
        {
            if (properties == null)
            {
                this.properties = new Dictionary<string, object>();
            }
            else
            {
                this.properties = new Dictionary<string, object>(properties);
            }
        }

        public object GetProperty(string propertyName)
        {
            return properties.ContainsKey(propertyName) ? properties[propertyName] : null;
        }

        public Dictionary<string, object> GetProperties()
        {
            return properties;
        }

        public bool Matches(InstrumentSpec otherSpec)
        {
            foreach (string propertyName in otherSpec.GetProperties().Keys)
            {
                if (!properties.ContainsKey(propertyName) || !properties[propertyName].Equals(otherSpec.GetProperty(propertyName)))
                {
                    return false;
                }
            }
            return true;
        }
    }

}

