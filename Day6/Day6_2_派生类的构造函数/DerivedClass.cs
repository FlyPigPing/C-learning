using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2_派生类的构造函数
{
    internal class DerivedClass:BaseClass
    {
        private int y;
        //public DerivedClass():base()
        public DerivedClass()
        {//调用父类的无参数构造函数

            Console.WriteLine("DerivedClass无参数构造函数");

        }
        public DerivedClass(int x,int y):base(x)
        {
            this.y = y;
            //this.z = x;
            //base.z = y;
            Console.WriteLine("y赋值完成");
        }

    }
}
