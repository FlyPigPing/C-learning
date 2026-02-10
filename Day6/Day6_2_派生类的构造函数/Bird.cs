using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2_派生类的构造函数
{
    internal class Bird : IFly,IB//实现接口
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Method1()
        {
            throw new NotImplementedException();
        }

        public void Method2()
        {
            throw new NotImplementedException();
        }
    }
}
