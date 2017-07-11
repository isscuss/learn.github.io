using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 操作列表的属性和方法
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>(10);
            intList.Add(160);
            intList.Add(88);
            intList.Add(789);
            intList.Add(443);
            intList.Add(21);

            //intList.Insert(2, 665);//索引处，插入值
            //foreach(var temp in intList)
            //{
            //    Console.Write(temp + " ");
            //}
            //Console.ReadKey();

            //intList.RemoveAt(2);//移除指定索引的值
            //foreach (var temp in intList)
            //{
            //    Console.Write(temp + " ");
            //}
            //Console.ReadKey();

            //int index = intList.IndexOf(43);//正序寻找值的位置
            //int index2 = intList.LastIndexOf(160);//逆序寻找值的位置
            //Console.WriteLine("{0}+{1}",index,index2);
            //Console.ReadKey();

            //Sort排序
            intList.Sort();
            foreach (var temp in intList)
            {
                Console.Write(temp + " ");
            }
            Console.ReadKey();
            

        }
    }
}
