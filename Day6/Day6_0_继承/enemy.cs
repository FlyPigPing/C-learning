using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_0_继承
{
    internal class enemy
    {
        private float hp;
        private float speed;

        public float HP {  get { return hp; } set { hp = value; } }
        public float Speed {  get { return speed; } set { speed = value; } }

        public void AI()
        {
            Move();
            Console.WriteLine("公有enemy1的AI方法");
        }

        //设置为虚方法
        //public virtual void Move()
        //{
        //    Console.WriteLine("公有enemy1的Move方法");
        //}
        public void Move()
        {
            Console.WriteLine("公有enemy1的Move方法");
        }



    }
}
