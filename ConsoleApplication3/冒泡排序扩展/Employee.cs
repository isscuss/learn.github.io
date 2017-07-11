using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序扩展
{
    class Employee
    {
        public string Name { get; private set; }//姓名属性
        public int Salary { get; private set; }//薪水属性
        
        public Employee(string name,int salary)//自己定义构造函数
        {
            this.Name = name;
            this.Salary = salary;
        }
        //如果薪水1大于薪水2，则返回true（定义专门处理薪水排序的方法，然后通过Func委托引用）
        public static bool Compare(Employee e1, Employee e2)//直接把该类的变量设为形参
        {
            if (e1.Salary > e2.Salary) return true;
            return false;
        }

        public override string ToString()//重写该方法
        {
            return Name + ":" + Salary;
        }
    }
}
