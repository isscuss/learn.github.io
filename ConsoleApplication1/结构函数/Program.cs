using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构函数
{
    //定义一个输出外国人名字的结构函数
    struct CustomerName
    {
        public string firstName;
        public string lastName;
        public string GetName()
        {
            return firstName + " " + lastName;
 
        }
    }
    //定义一个坐标的结构函数，输入坐标，然后输出坐标的长度，通过一个叫distance的结构函数
    struct Vector3
    {
        public float x;
        public float y;
        public float z;
        public double Distance()//返回值要是一个double才行，float太小啦
        {
            return Math.Sqrt(x * x + y * y + z * z);
 
        }
 
    }
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerName myName;
            //myName.firstName = "balls";
            //myName.lastName = "isscuss";
            //Console.WriteLine("My name is " + myName.GetName());
            //Console.ReadKey();


            Vector3 myVector;
            myVector.x = 4;
            myVector.y = 3;
            myVector.z = 8;
            Console.WriteLine("向量的长度为：" + myVector.Distance());
            Console.ReadKey();
            
        }
    }
}
