using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_3_泛型类
{
    internal class ClassA<T,A>//T代表一个数据类型，当使用ClassA构造的时候，
                              //需要制定T的类型（例如：列表List<int>）
                              //可以声明俩个类型，如果T：int，A:float,
                              //那么a,b就是int类型的，c就是float类型的
    {
        private T a;
        private T b;
        private A c;
        public ClassA(T a, T b,A c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public string GetSum()
        {
            return a + "" + b;
        }

    }
}
