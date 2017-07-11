using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程_继承
{
    class Boss:Enemy
    {
        public void Attack()
        {
            
            Console.WriteLine("boss正在攻击");
        }

        //重写Enemy中的虚函数
        //public override void Move()
        //{
        //    Console.WriteLine("这是boss的移动方法");
        //}

        //隐藏方法
        public new void Move()
        {
            Console.WriteLine("这是boss的移动方法");
 
        }
    }
}
