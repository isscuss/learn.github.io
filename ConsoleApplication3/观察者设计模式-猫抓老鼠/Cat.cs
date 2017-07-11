using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者设计模式_猫抓老鼠
{
    class Cat
    {
        private string name;
        private string color;
         public Cat(string name,string color)//构造函数
         {
             this.name = name;
             this.color = color;
          
         }

        //猫进屋的状态
         //public void CatComing(Mouse mouse1,Mouse mouse2)
         public void CatComing()//优化后的方法,观察者
         {
             Console.WriteLine(color + "的猫：" + name + "过来啦，喵喵喵");
             //mouse1.RunAway();
             //mouse2.RunAway();
             if (catCome != null)//安全性检测
                 catCome();
         }
         public Action catCome;//定义一个委托
    }
   
}
