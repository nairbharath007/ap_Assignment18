using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppClassLibrary.Service
{
    public class MovieStoreException : Exception
    {
        public MovieStoreException(string message) : base(message) { }
    }
}

