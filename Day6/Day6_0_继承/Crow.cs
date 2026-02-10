using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_0_继承
{
    internal class Crow : MyBird//继承一个抽象类，必须去实现它的方法
    {
        public override void Fly()
        {
            //throw new NotImplementedException();
            Console.WriteLine("乌鸦在飞");
        }
    }
}
