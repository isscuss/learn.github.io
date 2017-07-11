using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 列表的创建和使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建列表有三种方法，一般用匿名方法创建列表
            //List<int> scoreList = new List<int>();
            //var scoreList = new List<int>();//匿名方法
            //var scoreList = new List<int>() { 1, 2, 3 };//给列表添加部分初始值

            //scoreList.Add(12);//添加值到List中
            //Console.WriteLine(scoreList[2]);//通过索引也可以调用List中的值
            //Console.ReadKey();

            //通过Capacity获取和设置数组长度，通过Count获取列表内现存数据数目
            var intList=new List<int>(10);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("长度为：" + intList.Capacity + " 数据有：" + intList.Count);
                intList.Add(10);
            }
            Console.ReadKey();
        }
    }
}
