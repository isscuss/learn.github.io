using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            byte myByte = 34;
            int score = 6000;
            long count = 10000000000000000;
            Console.WriteLine("byte:{0} int:{1} long:{2}",myByte,score,count);
            float myFloat = 12.5f;
            double myDouble = 14.6;
            Console.WriteLine("float:{0} double:{1}",myFloat,myDouble);
            char myChar = 'a';
            string myString = "adscd";
            string myString2 = "";
            bool myBool = false;
            Console.WriteLine("char:\t\\\"{0}\"\n string:{1}\n string:{2}\n bool:{3}\n", myChar, myString, myString, myBool);
            Console.ReadKey();
        }
    }
}
