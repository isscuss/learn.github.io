using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数的递归_结构体_数学运算的练习
{
    class Program
    {
        //定义一个结构体，其中的参数包括学号，姓名，性别，成绩，赋值后，请通过结构函数输出各参数值咯
        struct Student
        {
            public int number;
            public string name;
            public bool isGirl;
            public int score;
            public void Show()
            {
                Console.Write("学号：" + number + "姓名:" + name + "性别：" + (isGirl ? "女" : "男") + "成绩：" + score);
            }


        }
        //利用递归的方法求5！（其实就是f(n)=n*f(n-1)的递归嘛，终止条件就是n=1的时候咯）
        static int Factorial(int n)
        {
            if (n == 1) return 1;//终止条件嘛，这个东西
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Factorial(3));

            //Student stu1;
            //stu1.number = 56;
            //stu1.name = "isscuss";
            //stu1.isGirl = false;
            //stu1.score = 98;
            //stu1.Show();
            //Console.ReadKey();

            //正数输入，四舍五入掉小数部分，输出仅整数部分
            double number = Convert.ToDouble(Console.ReadLine());
            //int zhengshu = (int)number;
            //double res = number - zhengshu;
            //if (res >= 0.5f)
            //{
            //    zhengshu++;
            //}
            //Console.WriteLine(zhengshu);

            int res = (int)(number + 0.5f);//利用显式转换，一行代码简化以上的复杂步骤
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
