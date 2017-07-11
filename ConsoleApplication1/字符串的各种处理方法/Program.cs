using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串的各种处理方法
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "www.baidu.COM";
            //字符串其实就是一个数组，可以通过.Length直接访问一个字符串的长度
            //for (int i=0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
 
            //}
            //Console.ReadKey();

            //string res = str.ToLower();//如果有大写字母，全部变成小写字母
            //string res = str.ToUpper();//同理，有小写字母，则全部变成大写字母
            //string res = str.Trim();//去掉字符串前后的空格，对原字符串没有影响
            //string res = str.TrimStart();
            //string res str.TrimEnd();
        
            //Console.WriteLine(str);
            //Console.WriteLine(res);
            string[] strArray = str.Split('.');//把原字符串按照指定的字符进行拆分，得到一个拆分后的数组
            foreach (string temp in strArray)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
}
