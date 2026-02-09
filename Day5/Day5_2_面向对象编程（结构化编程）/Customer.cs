using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_2_面向对象编程_结构化编程_
{
    //定义一个新的类型
    internal class Customer
    {
        //数据成员:里面包含四个字段
        public string name;
        public string address;
        public int age=0;
        public string buyTime;
        //函数成员：定义一个方法
        public void Show()
        {
            Console.WriteLine("名字：" + name);
            Console.WriteLine("地址：" + address);
            Console.WriteLine("年龄：" + age);
            Console.WriteLine("购买时间：" + buyTime);
        }
    }
}
