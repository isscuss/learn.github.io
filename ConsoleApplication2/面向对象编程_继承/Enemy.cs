using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程_继承
{
    class Enemy//传说中的基类
    {
        private float hp;
        private float speed;
        

        //函数成员
        public float HP
        {
            get { return hp; }
            set { hp = value; }
        }
        public float Speed
        {
            
            get { return speed; }
            set { speed = value; }
        }
        public void AI()
        {
            Move();
            Console.WriteLine("这里是敌人defalut的AI的方法");
        }
        

        //虚函数
        //public virtual void Move()
        //{
        //    Console.WriteLine("这里是defalut移动的方法啊");
        //}

        //隐藏方法
        public void Move()
        {
            
            Console.WriteLine("这是默认的移动方法");
        }
    }
}
