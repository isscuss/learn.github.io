using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> strList = new List<string>();
            //strList.Add("123");
            //strList.Add("456");
            //strList.Add("789");
            //Console.WriteLine(strList[1]);
            //strList.Remove("789");
            //Console.WriteLine(strList.Count);
            //strList.Clear();
            //Console.WriteLine(strList.Count);
            //Console.ReadKey();
            //SeqList<string> seqList = new SeqList<string>();
            LinkList<string> seqList = new LinkList<string>();
            seqList.Add("123");
            seqList.Add("456");
            seqList.Add("789");
            Console.WriteLine(seqList.GetEle(2));
            Console.WriteLine(seqList[0]);
            seqList.Insert("775", 1);
            for (int i = 0; i < seqList.GetLength(); i++) 
            {
                Console.Write(seqList[i] + " ");
            }
            Console.WriteLine();
            seqList.Delete(0);
            for (int i = 0; i < seqList.GetLength(); i++)
            {
                Console.Write(seqList[i] + " ");
            }
            Console.WriteLine();
            seqList.Clear();
            Console.WriteLine(seqList.GetLength());
            Console.ReadKey();
        }
    }
}
