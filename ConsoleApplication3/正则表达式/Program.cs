using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace 正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "what's up,man?";
            string res = Regex.Replace(s, "^", "开始：");//定位字符串开头
            Console.WriteLine(res);
            Console.ReadKey();


            //string s = "just so so";
            //string res = Regex.Replace(s, "$", "结束咯");
            //Console.WriteLine(res);
            //Console.ReadKey();

            //读取用户输入的密码（要求纯数字），判断是否符合规则
            
            //经典for循环判断
            //string s = Console.ReadLine();
            //bool isMatch = true;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] < '0' || s[i] > '9')
            //    {
            //        isMatch = false;
            //        break;
 
            //    }
            //}
            //if (isMatch == true)
            //{
            //    Console.WriteLine("符合规则");
            //}
            //else
            //{
            //    Console.WriteLine("不符合规则");
            //}
            //Console.ReadKey();

            //正则表达式判断
            //string s = Console.ReadLine();
            //string pattern = @"^\d*$";//正则表达式
            //bool isMatch = Regex.IsMatch(s, pattern);
            //Console.WriteLine(isMatch);
            //Console.ReadKey();

            //把除“ahou”以外的任意字符变成“*”
            //string s = "i am a human";
            //string pattern = @"[^ahou]";//正则
            //string s2 = Regex.Replace(s, pattern, "*");
            //Console.WriteLine(s2);
            //Console.ReadKey();

            //重复描述字符
            //检测qq号是否合法输入(纯数字，5~12位)
            //string qq = Console.ReadLine();
            //string pattern = @"^\d{5,12}$";//正则
            //Console.WriteLine(Regex.IsMatch(qq,pattern));
            //Console.ReadKey();

            //检测字符串中的数字或字母，当做结果过滤出来(通过择一“|”)
            //string s = "alkjfalk,245236[]~";
            //string pattern = @"\d|[a-z]";//择一匹配
            //MatchCollection col = Regex.Matches(s, pattern);//通过matches匹配，放到MatchCollectionzhong中
            //foreach (Match temp in col)//foreach遍历输出
            //{
            //    Console.WriteLine(temp.ToString());//调用匹配到的字符串
            //}
            //Console.ReadKey();

            //检测名字中的；,或.符号，把名字分割开，然后输出不同的名字
            //1
            //string s = "zhang;li,wang.liao";
            //string pattern = @"[;,.]";//可选字符的匹配
            //string[] array = Regex.Split(s, pattern);//利用静态方法Split修改，然后放到数组中
            //foreach (var temp in array)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //2
            //string s = "li;qiu,liao.wu";
            //string pattern = @"[;]|[,]|[.]";//择一匹配
            //string[] array = Regex.Split(s, pattern);
            //foreach (var temp in array)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //分组操作符
            ///将符合分组字符，重复操作两次的字符串替换成5555
            //string inputStr = Console.ReadLine();
            //string pattern = @"(ab\w{2}){2}";
            //Console.WriteLine("符合条件的替换成5555： " + Regex.Replace(inputStr, pattern, "5555"));
            //Console.ReadKey();

            //练习：检测ip地址输入的合法性(xxx.xxx.xxx.xxx),xxx的取值为0~255
            //string s = Console.ReadLine();
            //string ipPattern = @"^(((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?))";//分组操作符
            //bool isMatch = Regex.IsMatch(s, ipPattern);
            //Console.WriteLine(isMatch);
            //Console.ReadKey();
        }
    }
}
