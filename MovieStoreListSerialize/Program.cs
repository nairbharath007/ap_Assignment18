using MovieStoreListSerialize.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreListSerialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieController controller = new MovieController();
            controller.Start();
        }
    }
}
