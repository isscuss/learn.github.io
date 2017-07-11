using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程_继承
{
    abstract class Bird//抽象类
    {
        private float speed;
        public void Eat()//普通函数
        {
 
        }

        public abstract void Fly();//抽象函数
    }
}
