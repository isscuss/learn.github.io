using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断是否是回文串
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool isHui = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    isHui = false;
                    break;
                }
            }
            if (isHui)
            {
                Console.WriteLine("该字符串是回文串");
            }
            else 
            {
                Console.WriteLine("该字符串不是回文串");
            }
            Console.ReadKey();
        }
    }
}
