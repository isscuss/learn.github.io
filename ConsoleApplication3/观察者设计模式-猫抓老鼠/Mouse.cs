using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者设计模式_猫抓老鼠
{
    class Mouse
    {
        private string name;
        private string color;
        public Mouse(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        //老鼠逃跑功能
        public void RunAway()
        {
            Console.WriteLine(color + "的老鼠：" + name + "说猫来了，大家快跑");
        }
    }
}
