using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_字符串string
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "www.baidu.com";
            //int length = s.Length;
            //if (s == "www.baibai.com")
            //{
            //    Console.WriteLine("相同的");
            //}
            //else
            //{
            //    Console.WriteLine("不同的");
            //}
            //Console.WriteLine(length);
            //Console.ReadKey();

            //string s = "www.baidu.com";
            //s = "http://" + s;//运用加法运算符
            //Console.WriteLine(s);
            //Console.ReadKey();

             //string s = "www.baidu.com";
             //char q = s[4];
             //Console.WriteLine(q);
             //Console.ReadKey();

            //遍历字符串
            //string s = "www.baidu.com";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}
            //Console.ReadKey();

            //字符串的更多功能
            string s = "www.baidu.com";
            int res = s.CompareTo("gg");//比较字符串
            Console.WriteLine("比较结果： "+res);
            string newStr = s.Replace('.', '-');
            Console.WriteLine("替代字符后：" + newStr);
            string newStr2 = s.Replace("baidu", "goole");
            Console.WriteLine("替代字符串后：" + newStr2);
            string[] array = s.Split('.');//字符切割后，放到字符数组中去咯
            foreach (var temp in array)
            {
                Console.WriteLine(temp);
            }
            string newStr3 = s.Substring(4, 5);//子字符串的输出;
            Console.WriteLine("子字符串："+newStr3);
            int index = s.IndexOf("baidu");//查找子字符串的索引位置
            Console.WriteLine("位置在："+index);
            Console.ReadKey();
        }
    }
}
