using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _类的定义和声明
{
    public class Vector
    {
        //构造函数(可重载)
        public Vector()
        {
            Console.WriteLine("构造函数被调用咯");
        }

        public Vector(float x,float y,float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            length = Length();
        }
        //编程规范上，习惯把所有对象中的字段的修饰访问符，都设置成private
        //不让外部可以随意调用或修改字段值的内容，而是另外设置set方法来设置字段的值
        private float x, y, z, length;
        private int age;

        //使用属性访问字段
        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public int Age
        {
            set//利用属性，可以在设置值之前，做一些校检的工作，比如年龄不能小于0嘛
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
            get
            {
                return age;
            }
        }

        //最简洁的属性定义方法（编译器会自动提供一个字段来存储值）
        public string Name { get; set; }


        public void SetX(float x)
        {
            this.x = x;//this.x表示的是访问类中的字段或方法

        }

        public void SetY(float y)
        {
            this.y = y;//this.x表示的是访问类中的字段或方法

        }

        public void SetZ(float z)
        {
            this.x = z;//this.x表示的是访问类中的字段或方法

        }

        public float Length()
        {

            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

    }
}
