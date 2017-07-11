using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;
using System.IO;

namespace json操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法1 解析json
            //List<Skill> skillList=new List<Skill>();//实例化一个Skill1的列表存储数据
            ////使用jsonMapper去解析json文本
            //JsonData jsonData = JsonMapper.ToObject(File.ReadAllText("json技能信息.txt"));
            //foreach (JsonData temp in jsonData)//temp代表jsondata数组中的一个对象元素
            //{
            //    Skill skill=new Skill();//实例化一个Skill对象
            //    JsonData idValue = temp["id"];//通过字符索引器可以取得键值对的值
            //    JsonData nameValue = temp["name"];
            //    JsonData damageValue = temp["damage"];
            //    int id=Int32.Parse(idValue.ToString());//转换下类型，方便输出
            //    int damage = Int32.Parse(damageValue.ToString());
            //    //Console.WriteLine(id + ":" + nameValue.ToString() + ":" + damage);
            //    skill.id=id;
            //    skill.damage=damage;
            //    skill.name=nameValue.ToString();
            //    skillList.Add(skill);//添加到列表中
            //}
            //foreach(var temp in skillList)//遍历skill类的列表
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.ReadKey();

            //方法2 利用泛型解析json（简易得多）
            //Skill[] skillArray = JsonMapper.ToObject<Skill[]>(File.ReadAllText("json技能信息.txt"));
            //foreach (var tmep in skillArray)
            //{
            //    Console.WriteLine(tmep);
            //}
            //Console.ReadKey();

            //方法3 也是利用泛型解析json（用list代替数组）
            //List<Skill> skillList= JsonMapper.ToObject<List<Skill>>(File.ReadAllText("json技能信息.txt"));
            //foreach (var tmep in skillList)
            //{
            //    Console.WriteLine(tmep);
            //}
            //Console.ReadKey();

            //解析主角信息json
            Player p = JsonMapper.ToObject<Player>(File.ReadAllText("主角信息.txt"));
            Console.WriteLine(p);
            foreach (var temp in p.skillList)//另外单独遍历输集合skillLsit
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();

            //反向：把数据变成json文本，进行传输
            //Player p = new Player();
            //p.Name = "isscuss";
            //p.Level = 2264;
            //p.Age = 23;
            //string json = JsonMapper.ToJson(p);//转换
            //Console.WriteLine(json);
            //Console.ReadKey();
        }
    }
}
