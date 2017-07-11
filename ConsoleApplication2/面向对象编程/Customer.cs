using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程
{
    class Customer
    {
        //数据成员
        public string name;
        public string address;
        public int age;
        public string buyTime;
        //函数成员:定义一个方法,函数的声明
        public void Show()
        {
            Console.WriteLine("名字：" + name);
            Console.WriteLine("地址：" + address);
            Console.WriteLine("年龄：" + age);
            Console.WriteLine("购买时间" + buyTime);
        }

    }
}
