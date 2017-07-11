using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用泛型和索引器来实现集合类MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();//声明一个int类型的对象
            myList.Add(13);//测试添加方法是否正常使用
            myList.Add(24);
            myList.Add(6);
            myList.Add(77);
            myList.Add(789);
            myList.Add(555);
            myList.RemoveAt(3);//移除功能正常
            myList[0] = 100;//通过索引器修改值
            myList.Insert(2, 66);//插入功能正常
            for (int i = 0; i < myList.Count; i++)
            {
                //Console.WriteLine(myList.GetItem(i));//测试GetItem()方法是否正常
                Console.WriteLine(myList[i]);//测试索引器是否正常工作
                Console.WriteLine(myList.IndexOf(789) + "正逆 " + myList.LastIndexOf(789));//测试正逆检索功能
            }
       
            myList.Sort();//排序方法
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(" " + myList[i]);//通过索引器取值
              
            }
                Console.WriteLine();
                Console.ReadKey();
        }
    }
}
