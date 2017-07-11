using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 派生类的构造函数
{
    class DriverClass:BaseClass
    {
        private int y;
        public DriverClass():base()//调用无参的父类构造函数，base可有可无
        {
            Console.WriteLine("这是子类的构造函数");
        }

        public DriverClass(int x,int y):base(x)
        {
            this.y = y;
            Console.WriteLine("子类的y赋值完毕");
        }
    
    }
}
