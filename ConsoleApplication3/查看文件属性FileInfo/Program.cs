using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 查看文件属性FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //文件操作
            //FileInfo fileInfo = new FileInfo("TextFile1.txt");//相对路径
            //FileInfo fileInfo = new FileInfo(@"E:\C#\ConsoleApplication3\查看文件属性FileInfo\bin\Debug\TextFile1.txt");//绝对路径，因为存在多个“\”，所以前面添加@消除转义字符的影响
            //Console.WriteLine(fileInfo.Exists);//判断文件是否存在
            //Console.WriteLine(fileInfo.Name);//查看“文件名.后缀”
            //Console.WriteLine(fileInfo.Directory);//查看文件所在的，绝对路径
            //Console.WriteLine(fileInfo.Length);//查看文件的字节大小
            //Console.WriteLine(fileInfo.IsReadOnly);//查看文件是否只读


            ////fileInfo.Delete();//删除目标文件
            ////fileInfo.CopyTo("sec.txt");//复制文件，改名

            //FileInfo fileInfo2 = new FileInfo("nice.exe");
            //if (fileInfo2.Exists == false)
            //{
            //    fileInfo2.Create();//创建当前不存在的文件
            //}
            ////fileInfo.MoveTo("naive.txt");//重命名操作
            //Console.ReadKey();

            //文件夹操作(按照完整路径名)
            //DirectoryInfo dirInfo = new DirectoryInfo(@"E:\C#\ConsoleApplication3\查看文件属性FileInfo\bin\Debug");//文件夹的绝对路径
            //Console.WriteLine(dirInfo.Exists);//是否存在
            //Console.WriteLine(dirInfo.Name);//名字
            //Console.WriteLine(dirInfo.Parent);//父目录
            //Console.WriteLine(dirInfo.Root);//根目录
            //Console.WriteLine(dirInfo.CreationTime);//创建时间
            //dirInfo.CreateSubdirectory("isscuss");//创建子目录
            //Console.ReadKey();

            //文件夹操作（相对路径）
            DirectoryInfo dirInfo = new DirectoryInfo("test");//相对路径（就是程序集所在路径）
            if(dirInfo.Exists==false)
            {
                dirInfo.Create();//创建一个新的文件夹
            }
        }
    }
}
