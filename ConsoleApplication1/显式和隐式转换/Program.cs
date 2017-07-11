using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 显式和隐式转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte myByte = 123;
            //int myInt = myByte;//小类型数据转化成大类型数据，直接隐式转换
            //float myfloat = myInt;
            //myInt = (int)myfloat;//显式转换，大类型数据转成小类型

            string str = "123";
            int num = Convert.ToInt32(str);//str中存的是整数则用toint，若有小数点，就应该是todouble了

            int num1 = 234556;
            string str2 = Convert.ToString(num1);//可以把数字直接变成字符串
            string str3 = num1 + "";//一个int double float类型直接加一个空的字符串，就可以直接转变成string类型
            Console.WriteLine(str3);
            Console.ReadKey();
        }
    }
}
