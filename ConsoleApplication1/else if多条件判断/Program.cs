using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if多条件判断
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int score = Convert.ToInt32(str);
            if (score >= 90)
            {
                Console.WriteLine("优秀！");
            }else if(score>=80&&score<90)
            {
                Console.WriteLine("良好！");
            }
            else if (score >= 60 && score <= 79)
            {
                Console.WriteLine("中等吧~");
            }
            else
            {
                Console.WriteLine("差，继续努力吧~");
            }
            Console.ReadKey();
        }
    }
}
