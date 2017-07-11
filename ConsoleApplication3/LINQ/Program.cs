using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化武林高手
            var masterList = new List<MartialArtsMaster>(){ 
    new MartialArtsMaster(){ Id = 1, Name = "黄蓉",    Age = 18, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 9  },
    new MartialArtsMaster(){ Id = 2, Name = "洪七公",  Age = 70, Menpai = "丐帮", Kongfu = "打狗棒法",  Level = 10 },
    new MartialArtsMaster(){ Id = 3, Name = "郭靖",    Age = 22, Menpai = "丐帮", Kongfu = "降龙十八掌",Level = 10 },
    new MartialArtsMaster(){ Id = 4, Name = "任我行",  Age = 50, Menpai = "明教", Kongfu = "葵花宝典",  Level = 1  },
    new MartialArtsMaster(){ Id = 5, Name = "东方不败",Age = 35, Menpai = "明教", Kongfu = "葵花宝典",  Level = 10 },
    new MartialArtsMaster(){ Id = 6, Name = "林平之",  Age = 23, Menpai = "华山", Kongfu = "葵花宝典",  Level = 7  },
    new MartialArtsMaster(){ Id = 7, Name = "岳不群",  Age = 50, Menpai = "华山", Kongfu = "葵花宝典",  Level = 8  },
    new MartialArtsMaster() { Id = 8, Name = "令狐冲", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 },
    new MartialArtsMaster() { Id = 9, Name = "梅超风", Age = 23, Menpai = "桃花岛", Kongfu = "九阴真经", Level = 8 },
    new MartialArtsMaster() { Id =10, Name = "黄药师", Age = 23, Menpai = "梅花岛", Kongfu = "弹指神通", Level = 10 },
    new MartialArtsMaster() { Id = 11, Name = "风清扬", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10 }
                                                       };
            //初始化武学
            var kongfuList = new List<Kongfu>(){
    new Kongfu(){Id=1, Name="打狗棒法", Power=90},
    new Kongfu(){Id=2, Name="降龙十八掌", Power=95},
    new Kongfu(){Id=3, Name="葵花宝典", Power=100},
    new Kongfu(){Id=  4, Name = "独孤九剑", Power = 100 },
    new Kongfu(){Id = 5, Name = "九阴真经", Power = 100 },
    new Kongfu(){Id = 6, Name = "弹指神通", Power = 100 }
                                               };
            //查询所有武学级别大于8的武林高手
            //方法1：foreach
            //var res = new List<MartialArtsMaster>();
            //foreach (var temp in masterList)
            //{
            //    if (temp.Level > 8)
            //    {
            //        res.Add(temp);
            //    }
            //}
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //方法2：通过LINQ进行查询（表达式写法）
            //var res = from m in masterList//from后面设置查询的集合
            //          where m.Level > 8//where后面跟上查询的条件
            //          select m.Name;//查询结果的返回(可以选择，仅查询Name类数据)
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //方法3：扩展方法
            //var res = masterList.Where(Test1);
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //方法4：扩展方法（Lambda表达式）
            //var res = masterList.Where(m => m.Level > 8);
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //var res2 = masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮");//添加两个以上的限制条件，用&&符号连接
            //foreach (var temp in res2)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //var res2 = from m in masterList
            //           where m.Level > 8 && m.Menpai == "丐帮"//添加两个以上的限制条件，用&&符号连接
            //           select m.Name;
            //foreach (var temp in res2)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //LINQ联合查询(表达式写法)
            //var res = from m in masterList
            //          from k in kongfuList
            //          //select new { master = m, kongfu = k };//创建一个临时对象,masterList和kongfuList中的对象一一映射对应

            //          //where m.Kongfu == k.Name
            //          //select new { master = m, kongfu = k };
                      

            //          //取得所学功夫杀伤力大于90的武林高手
            //          where m.Kongfu == k.Name && k.Power > 90
            //          select m;
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();
            
            //LINQ联合查询(扩展写法)
            //var res = masterList.SelectMany(m => kongfuList, (m, k) => new { master = m, kongfu = k }).Where(x=>x.master.Kongfu==x.kongfu.Name&&x.kongfu.Power>90);//创建一个临时对象,然后在where后面添加限制条件
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //对查询结果做排序OrderBy（descending）表达式
            //var res = from m in masterList
            //          where m.Level > 8 && m.Menpai == "丐帮"
            //          //orderby m.Age descending//后面添加descending，就是逆序排列
            //          orderby m.Level, m.Age//按照多个字段进行排序，如果字段的属性相同，就按照第二属性排序
            //          select m;
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //orderby扩展方法
            //var res = masterList.Where(m => m.Level > 8).OrderBy(m => m.Level).ThenBy(m => m.Age);//Thenby是第二属性
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //join on集合联合
            //var res = from m in masterList
            //          join k in kongfuList on m.Kongfu equals k.Name//on后面跟的是限制条件(Kongfu==Name)
            //          where k.Power > 90
            //          select new { master = m, kongfu = k };//创建临时对象
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //分组查询 into groups(把武林高手按照所学的功夫进行分类，查看哪个功夫学的人数最多)
            //var res = from k in kongfuList//以kongfuList为主导，进行分组
            //          join m in masterList on k.Name equals m.Kongfu
            //          into groups//分到组里面
            //          orderby groups.Count()//排序
            //          select new { Kongfu = k, count = groups.Count() };
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //按照自身字段分组
            //var res = from m in masterList
            //          group m by m.Kongfu into g//按照Kongfu字段进行分组,分组结果放到g里面
            //          select new { count = g.Count(),key = g.Key };
            //foreach (var temp in res)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();   

            //量词操作符，any和all，用于判断，而不是用于分组
            bool res = masterList.Any(m => m.Menpai == "丐帮");//有一个满足条件就行了
            Console.WriteLine(res);
            bool res2 = masterList.All(m => m.Menpai == "丐帮");//要求全部满足条件
            Console.WriteLine(res2);
            Console.ReadKey();
        }
        //过滤方法
        static bool Test1(MartialArtsMaster master)
        {
            if (master.Level > 8) return true;
            return false;
        }
    }
}
