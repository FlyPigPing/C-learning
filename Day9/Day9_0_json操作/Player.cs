using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Day9_0_json操作
{
    internal class Player
    {
        //public string name;//字段或者属性名需要跟json里面的对应
        //public int level;
        public string Name {  get; set; }
        public int Level {  get; set; }
        public int Age {  get; set; }
        public List<Skill> SkillList { get; set; }

        public override string? ToString()
        {
            return string.Format("Name:{0},Level:{1},Age:{2},SkillList:{3}", Name, Level, Age,SkillList);
        }

    }
}
