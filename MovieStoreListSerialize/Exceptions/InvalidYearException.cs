﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreListSerialize.Exceptions
{
    internal class InvalidYearException : Exception
    {
        public InvalidYearException(string message) : base(message)
        {
        }
    }
}
