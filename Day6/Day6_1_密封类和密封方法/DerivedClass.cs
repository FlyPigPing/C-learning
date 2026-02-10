using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_1_密封类和密封方法
{
    internal class DerivedClass:BaseClass//sealed类无法被继承
    {

        public sealed override void Move()
        {
            base.Move();
        }
    }
}
