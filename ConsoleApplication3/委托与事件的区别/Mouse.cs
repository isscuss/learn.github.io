using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托与事件的区别
{
    class Mouse
    {
        private string name;
        private string color;
        public Mouse(string name, string color,Cat cat)
        {
            this.name = name;
            this.color = color;
            cat.catCome+=this.RunAway;//把自身的逃跑方法注册到猫的catcom事件里面
        }

        //老鼠逃跑功能
        public void RunAway()
        {
            Console.WriteLine(color + "的老鼠：" + name + "说猫来了，大家快跑");
        }
    }
}
