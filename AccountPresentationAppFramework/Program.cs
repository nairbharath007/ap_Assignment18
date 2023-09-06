using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPresentationAppFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountController controller = new AccountController();
            controller.Start();
        }
    }
}
