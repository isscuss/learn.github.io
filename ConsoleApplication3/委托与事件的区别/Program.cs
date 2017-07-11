using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托与事件的区别
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("加菲猫", "黄色");
            Mouse mouse1 = new Mouse("李琦", "黑色",cat); 
            Mouse mouse2 = new Mouse("混蛋", "紫色",cat);
  
            cat.CatComing();
            Console.ReadKey();
        }
    }
}
