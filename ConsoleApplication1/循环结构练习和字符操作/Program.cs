using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环结构练习和字符操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //猜字游戏：设定一个0~50的随机数,让玩家去猜，如果猜大了，就提示比当前猜的数字大，否则比当前数字小
            //Random random = new Random();//设定生成一个随机数
            //int number = random.Next(0, 51);//该随机数的取值范围是0~51
            //Console.WriteLine("您好，我有一个数字，请您猜猜是多少");
            //while (true)//需要多次输入的，一般都是死循环这些东西
            //{
            //    int temp = Convert.ToInt32(Console.ReadLine());
            //    if (temp < number)
            //    {
            //        Console.WriteLine("猜小了哦，请继续猜吧");
            //    }
            //    else if (temp > number)
            //    {
            //        Console.WriteLine("猜大了呢，请继续猜");

            //    }
            //    else 
            //    {
            //        Console.WriteLine("恭喜您猜对了！");
            //        break;//跳出循环
            //    }
            //}
            //Console.ReadKey();


            //字符串加密程序，加密规则如下所示:a->d,b->e...x->a,y->b,z->c，大写字母同理，字符往后移三位，并循环
            string str = Console.ReadLine();//先输出一个字符串
            string tempStr = "";//临时字符串，一开始为空值
            for (int i = 0; i < str.Length; i++)//遍历字符串中的每一个字符
            {
                if (str[i] >= 'a' && str[i] <= 'z')//该字符在a~z之间
                {
                    int num = str[i];
                    num += 3;//字符往后移动三位
                    char temp = (char)num;
                    if (temp > 'z')//处理xyz三个数，构成循环系统
                    {
                        temp = (char)(temp - 'z' + 'a' - 1);
                    }
                    tempStr += temp;//空的字符串加上加密后的字符
 
                }
                else if (str[i] >= 'A' && str[i] <= 'Z')//同理可得
                {

                    int num = str[i];
                    num += 3;//字符往后移动三位
                    char temp = (char)num;
                    if (temp > 'Z')//处理xyz三个数，构成循环系统
                    {
                        temp = (char)(temp - 'Z' + 'A' - 1);
                    }
                    tempStr += temp;//空的字符串加上加密后的字符
                }
                else
                {
                    tempStr += str[i];//输入其他非字母的字符时，啥也不改变
                }
 
            }
            Console.WriteLine(tempStr);
            Console.ReadKey();
        }
    }
}
