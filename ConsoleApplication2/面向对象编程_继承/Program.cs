using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boss boss = new Boss();
            //boss.AI();//父类的公有方法和字段，子类都可以调用
            //boss.Attack();
            //Console.ReadKey();

            //Enemy enemy;
            //enemy = new Boss();//父类声明的对象，可以使用子类去构造
            //Boss boss = (Boss)enemy;//可以用显示转换把enemy强制变成Boss子类，因为本质就是子类
            //boss.Attack();
            //Enemy1 enemy1 = new Enemy1();
            //enemy1.Move();
            //Console.ReadKey();


            //虚函数的运用
            //Boss boss = new Boss();
            //boss.AI();//优先级会是自己override过的虚函数
            //Console.ReadKey();

            //隐藏方法
            //Boss boss = new Boss();
            //boss.Move();
            //Enemy boss2 = new Boss();
            //boss2.Move();
            //Console.ReadKey();


            //抽象类（不可构造，但可以声明）
            Bird crow1 = new Crow();
            crow1.Fly();//很有趣的是，抽象基类声明后的对象，不需要强制转换成子类，也可以直接使用子类的方法咯
            Console.ReadKey();
        }
    }
}
