using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 派生类的构造函数
{
    class BaseClass
    {
        private int x;
        //protected修饰符,只有子类可以访问该值
        protected int z;
        public BaseClass()//父类构造函数
        {
            Console.WriteLine("这个是父类的构造函数哦");
        }

        public BaseClass(int x)//这个是父类有参数的构造方法
        {
            this.x = x;
            Console.WriteLine("父类参数x赋值完毕");
        }
    }
}
