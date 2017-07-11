using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 特性
{
    [AttributeUsage(AttributeTargets.Class)]//表示应用到的程序结构目标是Class
    sealed class MyTestAttribute:System.Attribute//一般需要继承自System.Attribute，声明为sealed
    {
        public string Descrition { get; set; }
        public string VersionNumber { get; set; }
        public int ID { get; set; }
        public MyTestAttribute(string des)
        {
            this.Descrition = des;//构造函数，添加一个描述什么的
        }
        
    }
    
}
