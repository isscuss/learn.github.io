using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举类型
{
    enum GameState:byte//枚举类型的变量值默认都是int，可以在后边加：byte变成其他类型，从而节省空间
    {
        Pause=100,//默认代码整数0,在后面添加数字就会改变默认值，虽然一般不会改，哈哈
        Failed,//默认代码整数1
        Success,//默认代码整数2
        Start//默认代码整数3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //利用定义好的枚举类型区声明变量，优点：清晰明了，代码方便阅读修改
            //GameState state = GameState.Start;
            //if (state == GameState.Start)//枚举类型的比较
            //{
            //    Console.WriteLine("当前处于游戏开始状态");
            //}
            //Console.ReadKey();


            //枚举类型的变量值默认从0开始
            GameState state = GameState.Start;
            int num = (int)state;//不可以直接把枚举值直接赋给int，要用显式转换
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
