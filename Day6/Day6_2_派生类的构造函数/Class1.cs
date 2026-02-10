using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2_派生类的构造函数
{
    internal class Class1
    {
        private int x;
        private int y;
        public static int z;//静态字段，创建对象，不包含它，用类命调用
        public static void TestMethod()
        {
            Console.WriteLine("这个是静态方法");
        }
    }
}
