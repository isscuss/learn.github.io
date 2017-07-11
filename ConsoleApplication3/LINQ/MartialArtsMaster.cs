using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class MartialArtsMaster
    {
        //武林高手
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Menpai { get; set; }
        public string Kongfu { get; set; }
        public int Level { get; set; }

        public override string ToString()//把要显示的参数，格式化
        {
            return string.Format("Id:{0},Name:{1},Age:{2},Menpai:{3},Kongfu:{4},Level:{5}", Id, Name, Age, Menpai, Kongfu, Level);
        }
    }
}
