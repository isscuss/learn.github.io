#define IsTest//宏定义
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace 特性
{
    [MyTest("简单的特性类",ID=100)]//使用了命名参数什么的
    class Program
    {
        [Obsolete("这个程序已经过时啦，别用啦大哥",false)]//处理过时的方法
        static void OldMethod()
        {
            Console.WriteLine("Oldmethod");
        }
        static void NewMethod()
        {
            Console.WriteLine("NewMethod");
        }
 
        [Conditional("IsTest")]//跟宏定义有关
        static void Test1()
        {
            Console.WriteLine("test1");
        }
        static void Test2()
        {
            Console.WriteLine("test2");
        }
        [DebuggerStepThrough]//跳过不需要调试的方法
        static void PrintOut(string str,[CallerFilePath]string fileName="",[CallerLineNumber]int lineNumber=0,[CallerMemberName]string methodName="")//调用者信息特性
        {
            Console.WriteLine(str);
            Console.WriteLine(fileName);
            Console.WriteLine(lineNumber);
            Console.WriteLine(methodName);
 
        }
        static void Main(string[] args)
        {
            OldMethod();
            NewMethod();
            Test1();
            Test2();
            Test1();
            PrintOut("123");
            Type type = typeof(Program);//通过typeof+类名也可以获取type对象
            object[] array = type.GetCustomAttributes(false);//获取该type对象所用到的特性类,不包含父类
            MyTestAttribute test = array[0] as MyTestAttribute;//实例化array【0】的元素
            Console.WriteLine(test.Descrition);
            Console.WriteLine(test.ID);
            Console.ReadKey();
        }
    }
}
