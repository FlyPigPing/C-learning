using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day5_3_类的定义与声明
{
    internal class Vihicle
    {
        public float speed;
        public float maxSpeed;
        public float weight;

        public void Run()
        {
            Console.WriteLine("这个车正在以" + speed + "速度行驶");
        }

        public void Stop()
        {
            speed = 0;
            Console.WriteLine("车辆停止");
        }
    }
}
