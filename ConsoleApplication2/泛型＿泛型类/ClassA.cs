using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型＿泛型类
{
    class ClassA<T>//T代表的是一个数据类型，当使用ClassA进行构造时，就需要制定T的类型咯
    {
        private T a;
        private T b;
        public ClassA(T a, T b)//带参数的构造函数
        {
            this.a = a;
            this.b = b;
        }
        public string GetSum()
        {
            return a +""+ b;
        }
    }
}
