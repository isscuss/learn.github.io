using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger = 5;
            goto myLabel;//直接跳转到标签语句，省略中间那些东西
            myInteger++;
            myLabel:Console.WriteLine(myInteger);
            Console.ReadKey();
        }
    }
}
