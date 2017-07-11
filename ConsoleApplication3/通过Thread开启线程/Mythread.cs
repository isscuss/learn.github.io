using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 通过Thread开启线程
{
    class Mythread
    {
        //定义需要传递的参数
        private string filename;
        private string filepath;

        public Mythread(string filename, string filepath)//定义构造函数
        {
            this.filename = filename;
            this.filepath = filepath;
        }
        public void DownFile()
        {
            Console.WriteLine("开始下载：" + filepath + filename);
            Thread.Sleep(2000);
            Console.WriteLine("下载完成");
        }
    }
}
