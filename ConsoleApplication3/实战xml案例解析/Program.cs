using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 实战xml案例解析
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skill> skillList = new List<Skill>();//创建一个skill列表存储信息
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("xml技能信息.txt");//加载要解析的xml
            XmlNode skillListNOde = xmlDoc.FirstChild.FirstChild;
            XmlNodeList skillNodeList = skillListNOde.ChildNodes;
            foreach (XmlNode skillNode in skillNodeList)
            {
                Skill skill = new Skill();
                XmlElement ele = skillNode["Name"];
                skill.Name = ele.InnerText;
                XmlAttributeCollection col = skillNode.Attributes;//获取该结点属性的集合
                skill.Id = Int32.Parse(col["SkillID"].Value);
                skill.EngName = col["SkillEngName"].Value;
                skill.TriggerType = Int32.Parse(col["TriggerType"].Value);
                skill.ImageFile = col["ImageFile"].Value;
                skill.AvailableRace = Int32.Parse(col["AvailableRace"].Value);
                skillList.Add(skill);
            }
            foreach (Skill s in skillList)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
