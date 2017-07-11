using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环练习和函数练习
{
    class Program
    {
        //求1！+2！+3！...+20！的和为多少（就是阶乘的和咯，在外面定义一个函数处理它，这样比较清晰明了）

        static int Factorial(int n)
        {
            int f=1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
 
        }
        
        static void Main(string[] args)
        {
            //有一个球，100米的高度自由落下，每次落到地面后反弹一半高度，问第10次落下后，一共走了多少距离，
            //会反弹多高???
            //float distance = 0;
            //float height = 100;
            //for (int i = 1; i <= 10; i++)
            //{
            //    distance += height;
            //    height /= 2;
            //}
            //Console.WriteLine("走过的距离为：" + distance + "第10次反弹的高度为：" + height);
            //Console.ReadKey();

            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                sum += Factorial(i);
 
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
