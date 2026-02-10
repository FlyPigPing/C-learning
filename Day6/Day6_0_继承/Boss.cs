using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_0_继承
{
    internal class Boss:enemy
    {
        public void Atack()
        {

            // AI();
            //hp = 100;
            //HP = 100;//父类里面是数据和函数成员才可以在子类里面访问
            Move();
            Console.WriteLine("公有Boss的Attack方法");
        }

        //重写Move方法，原来的方法不存在了
        //public override void Move()
        //{
        //    // base.Move();
        //    Console.WriteLine("公有Boss的Move方法");
        //}
        public new void Move()//当子类里面有一个签名和父类方法相同的时候，就会把父类中的方法隐藏
            //方法还存在
        {
            // base.Move();
            Console.WriteLine("公有Boss的Move方法");
        }
    }
}
