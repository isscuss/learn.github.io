using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程_继承
{
    class Crow:Bird

    {
        public override void Fly()
        {
            Console.WriteLine("乌鸦在飞");//重写Fly（）抽象函数函数
        }
    }
}
