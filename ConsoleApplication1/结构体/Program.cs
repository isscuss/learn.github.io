using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体
{
    class Program
    {
        //利用结构体定义坐标
        struct Position
        {
            public float x;
            public float y;
            public float z;
        }
        enum Direction//因为方向是固定4个，所以用枚举类型
        {
            West,
            North,
            East,
            South
        }
        struct Path
        {
            public float distance;//距离
            public Direction dir;//调用枚举类型的值
        }
        static void Main(string[] args)
        {
            //使用结构体声明变量时，相当于使用结构体中所有的变量去声明，使程序更加清晰
            Position enemy1;
            enemy1.x = 34;
            enemy1.y = 45;
            enemy1.z = 22;

            //使用结构体，显示路径=方向+距离嘛
            Path path1;
            path1.dir = Direction.East;//再次调用枚举类型
            path1.distance = 1000;//距离。。。。
            
        }
    }
}
