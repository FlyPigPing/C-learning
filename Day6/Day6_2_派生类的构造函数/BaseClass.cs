using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2_派生类的构造函数
{
    internal class BaseClass
    {
        private int x;
        protected int z;
        public BaseClass() {
            Console.WriteLine("BaseClass无参数构造函数");
        }
        public BaseClass(int x)
        {
            this.x = x;
            Console.WriteLine("x赋值完成");
        }

    }
}
