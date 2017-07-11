using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace xml操作
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skill> skillList = new List<Skill>();//创建技能信息的集合，用来存储技能信息
            //XmlDocument专门用来解析xml文档
            XmlDocument xmlDoc = new XmlDocument();
            //第一种解析方法：选择要加载解析的xml文档的名字
            //xmlDoc.Load("skillinfo.txt");
            //第二种解析方法：字符串解析xml
            xmlDoc.LoadXml(File.ReadAllText("skillinfo.txt"));
            //得到根节点
            XmlNode rootNode = xmlDoc.FirstChild;//获取第一个结点（就是根嘛）
            XmlNodeList skillNodeList = rootNode.ChildNodes;//获取当前根结点下，所有子节点的集合
            foreach (XmlNode skillNode in skillNodeList)//遍历根结点之下的子结点
            {
                Skill skill = new Skill();//创建一个skill对象
                XmlNodeList fieldNodeList = skillNode.ChildNodes;//获取子节点下的所有子节点
                foreach (XmlNode fieldNode in fieldNodeList)
                {
                    if (fieldNode.Name == "id")
                    {
                        int id = Int32.Parse(fieldNode.InnerText);//转换成int类型
                        skill.Id = id;
                    }
                    else if (fieldNode.Name == "name")
                    {
                        string name = fieldNode.InnerText;
                        skill.Name = name;
                        skill.Lang = fieldNode.Attributes[0].Value;//索引为0的属性
                    }
                    else
                    {
                        skill.Damage = Int32.Parse(fieldNode.InnerText);//伤害的值
                    }
                }
                skillList.Add(skill);
            }
            //遍历skillList列表，输出显示skill列表中的值
            foreach (Skill skill in skillList)
            {
                Console.WriteLine(skill);
            }
            Console.ReadKey();
        }
    }
}
