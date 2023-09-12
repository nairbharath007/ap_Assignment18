using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    public enum Builder
    {
        FENDER,
        MARTIN,
        GIBSON,
        COLLINGS,
        OLSON,
        RYAN,
        PRS,
        ANY
    }

    public static class BuilderExtensions
    {
        public static string ToString(this Builder builder)
        {
            switch (builder)
            {
                case Builder.FENDER: return "Fender";
                case Builder.MARTIN: return "Martin";
                case Builder.GIBSON: return "Gibson";
                case Builder.COLLINGS: return "Collings";
                case Builder.OLSON: return "Olson";
                case Builder.RYAN: return "Ryan";
                case Builder.PRS: return "PRS";
                default: return "Unspecified";
            }
        }
    }

}
