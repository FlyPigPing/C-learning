using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_4_XML操作
{
    //技能类
    internal class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lang {  get; set; }
        public int Damage {  get; set; }

        public override string? ToString()
        {
            return string.Format("id:{0},Name:{1},Lang:{2},Damage:{3}",Id,Name,Lang,Damage);
        }
    }
}
