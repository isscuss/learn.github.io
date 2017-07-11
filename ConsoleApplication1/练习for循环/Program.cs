using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //100~999之间的水仙花数,例子：水仙花数153=1*1*1 + 5*5*5 + 3*3*3
            //for (int i = 100; i < 1000; i++)//遍历100~999
            //{
            //    int ge = i % 10;//除以10求余，可以得到个位数
            //    int shi = (i / 10) % 10;//同理可得~
            //    int bai = i / 100;
            //    int res = ge * ge * ge + shi * shi * shi + bai * bai * bai;
            //    if (res == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();


            //3个可乐瓶子可以换1瓶可乐，请问：目前一共有364瓶可乐，最多可以喝几瓶可乐，剩余几个瓶子？
            int sum = 364;//目前的可乐数目
            int numEmpty = sum;//一开始的空瓶子数目
            while (numEmpty > 3)//如果空瓶子大于3，就可以继续换可乐来喝
            {
                sum += numEmpty / 3;//sum=sum+numEmpty/3
                int newCount = numEmpty / 3;//表示可以兑换几瓶新可乐
                int remainEmpty = numEmpty % 3;//表示剩余几个空瓶子没兑换(肯定小于3啦)
                numEmpty = newCount + remainEmpty;//第二代空瓶子，加入while循环
            }
            Console.WriteLine("一共喝了"+sum+"瓶可乐,剩余的空瓶子个数为："+numEmpty);//剩余的空瓶子肯定小于3啦
            Console.ReadKey();
        }
    }
}
