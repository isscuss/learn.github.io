using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _类的定义和声明
{
    class Vehicle
    {
        public float speed;
        public float maxSpeed;
        public float weight;
        public void Run()
        {
            Console.WriteLine("该车以" + speed + "的速度前行呢");
        }
        public void Stop() 
        {
            speed = 0;
            Console.WriteLine("车停下来了");
        }
    }
}
