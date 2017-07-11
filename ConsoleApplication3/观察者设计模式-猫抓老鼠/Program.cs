using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者设计模式_猫抓老鼠
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("加菲猫", "黄色");
            Mouse mouse1 = new Mouse("李琦", "黑色");
            cat.catCome += mouse1.RunAway;//注册的过程
            Mouse mouse2 = new Mouse("混蛋", "紫色");
            cat.catCome += mouse2.RunAway;
            //cat.CatComing(mouse1,mouse2);//猫的状态发生变化
            cat.CatComing();
            Console.ReadKey();
        }
    }
}
