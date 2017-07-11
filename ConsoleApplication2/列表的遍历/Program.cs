using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 列表的遍历
{
    class Program
    {

        static void Main(string[] args)
        {
            var intList = new List<int>(10);
            intList.Add(55);
            intList.Add(66);
            intList.Add(27);
            //for遍历
            //for (int i = 0; i < intList.Count; i++)
            //{
            //    Console.Write(" " + intList[i]);
            //}
            //Console.ReadKey();

            //foreach遍历
            foreach(var temp in intList)
            {
                Console.Write(temp + " ");
            }
            Console.ReadKey();
        }
    }
}
