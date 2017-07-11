using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg
{
    class Program
    {
        int a = 1;
        int b = 2;
         void Main()
        {
            a = b + a - (b = a);
            Console.WriteLine(a);
        }
    }
}
