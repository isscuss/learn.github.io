using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;                                                                                                                                                                        

namespace Excel操作
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "装备信息.xls";
            string connectionString= "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";//其中一个excel版本
            OleDbConnection connection=new OleDbConnection(connectionString);//创建连接到数据源的对象
            connection.Open();//打开连接
            string sql = "select * from [Sheet1$]";//定义一个sql查询命令
            OleDbDataAdapter adapter=new OleDbDataAdapter(sql,connection);//查询请求，其中包括查询命令和连接对象
            DataSet dataSet = new DataSet();//用来存放查询结果（dataTable）的数据
            adapter.Fill(dataSet);//把结果（dataTable）填充到dataSet中
            connection.Close();//关闭连接
            //取得数据（先从行入手，再到列）
            DataTableCollection tableCollection=dataSet.Tables;//取得当前集合中，所有的表格
            DataTable table = tableCollection[0];//取得索引为0的,那一张表格
            DataRowCollection rowCollection=table.Rows;//取得该表格中，所有行的数据
            foreach (DataRow row in rowCollection)//遍历每一行
            {
                for(int i=0;i<8;i++)//用for循环取得前八列的数据
                {
                    Console.Write(row[i] + " ");
                }
                Console.WriteLine();//隔一行
            }
            Console.ReadKey();
        }
    }
}
