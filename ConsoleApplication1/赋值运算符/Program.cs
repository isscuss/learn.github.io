﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 赋值运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 34;//赋值34
            num1+=12;//num1=num1+12=46
            num1 -= 12;//num1=num1-12=34
            num1 *= 2;//num1=num1*2=68
            num1 /= 2;//num1=num1/2=34
            num1 %= 4;//num1=num1%4=2
            Console.WriteLine(num1);
            Console.ReadKey();
        }
    }
}
