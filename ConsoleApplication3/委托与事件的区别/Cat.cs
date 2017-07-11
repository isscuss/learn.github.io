using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托与事件的区别
{
    class Cat
    {
        private string name;
        private string color;
        public Cat(string name, string color)//构造函数
        {
            this.name = name;
            this.color = color;

        }

        //猫进屋的状态

        public void CatComing()//优化后的方法,观察者
        {
            Console.WriteLine(color + "的猫：" + name + "过来啦，喵喵喵");
            if (catCome != null)//安全性检测
                catCome();
        }
        public event Action catCome;//定义一个事件,更安全
    }
}
