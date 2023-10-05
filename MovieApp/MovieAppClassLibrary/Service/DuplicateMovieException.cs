using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppClassLibrary.Service
{
    public class DuplicateMovieException : Exception
    {
        public DuplicateMovieException(string message) : base(message) { }
    }
}
