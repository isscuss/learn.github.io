using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json操作
{
    class Skill
    {//通过Skill类，引导json文本数据的输出
        public int id;
        public int damage;
        public string name;
        public override string ToString()
        {
            return string.Format("ID:{0},Damage:{1},Name:{2}", id, damage, name);//重写输出函数
        }
    }
}
