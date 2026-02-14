using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_0_json操作
{
    internal class Skill
    {

        public int id;
        public int damage;
        public string name;

        //public int Id { get; set; }
        //public string Name { get; set; }
        //public int Damage {  get; set; }

        public override string? ToString()
        {
            return string.Format("Id:{0},Damage:{1},Name:{2}",id,damage,name);
        }
    }
}
