using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序扩展
{
    class Program
    {
        static void Sort(int[] array)
        {
            bool swap = true;
            do
            {
                swap = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap);
         

        }

        //定义一个通用的排序方法，让这排序可以对自己定义的雇员类进行薪水的冒泡排序
        static void CommonSort<T>(T[] sortArray, Func<T, T, bool> compareMethod)//该泛型方法传递一个数组和一个Func委托类型
        {
            bool swap = true;
            do
            {
                swap = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (compareMethod(sortArray[i],sortArray[i+1]))
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap);
         
        }
        static void Main(string[] args)
        {
            //int[] array = new int[] { 23, 6, 27, 236, 8, 0, 2, 56 };
            //Sort(array);
            //foreach (var temp in array)
            //{
            //    Console.Write(temp + " ");
            //}
            //Console.ReadKey();

            Employee[] employees = new Employee[]//创建一个Employee类的数组
          {
              new Employee("gg",134),
              new Employee("naive",66),
              new Employee("simida",78),
              new Employee("mama",01)
          };
            CommonSort<Employee>(employees, Employee.Compare);//把该静态方法变成参数传递
            foreach (Employee temp in employees)
            {
                Console.WriteLine(temp.ToString());//在Employee类中重写该ToString（）方法
            }
            Console.ReadKey();
        }
    }
}
