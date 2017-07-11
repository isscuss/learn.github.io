using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射和特性
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();//类的数据，是存储在对象中的，type的对象只存储类的成员
            Type type = my.GetType();//通过对象获取该对象所属类的type对象
            Console.WriteLine(type.Name);//获取类名
            Console.WriteLine(type.Namespace);//获取命名空间
            Console.WriteLine(type.Assembly);//获取所在程序集
            FieldInfo[] array = type.GetFields();//获取类中的字段
            foreach (FieldInfo info in array)
            {
                Console.Write(info.Name + " ");
            }

            PropertyInfo[] array2= type.GetProperties();//获取公有属性
            foreach (PropertyInfo info in array2)
            {
                Console.Write (info.Name + " ");
            }

            MethodInfo[] array3 = type.GetMethods();//获取方法,包括父类的方法
            foreach (MethodInfo info in array3)
            {
                Console.Write(info.Name + " ");
            }
            Console.ReadKey();
        }
    }
}
