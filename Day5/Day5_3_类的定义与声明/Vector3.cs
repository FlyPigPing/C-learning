using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_3_类的定义与声明
{
    public class Vector3//设置为public,这样在别的项目中才可以访问
    {
        //编程规范，把所有的字段设置为private，只可以在类内部访问，不可以通过对象访问
        //public float x, y, z;
        private float x, y, z,length;
        private int age;
        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        public string Name { get; set; }//编译器会自动给我们提供一个字段，来存储name
        public int Age
        {
            get { return age; }
            set
            { 
                //通过set方法，在设置值之前做一些校验的工作
                if(value>=0)
                age = value; 
            }
        }
        
        public float X//也可以叫做getset方法
        {
            get { return x; }
            set { x = value; }
        }
        public Vector3()
        {
            Console.WriteLine("被调用了");
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            length = Length();
        }

        public void Set(float x,float y, float z)
        {
            //如果我们直接在方法内访问同名变量，优先访问最近的（形参）
            //x(形参) = x（形参）;
            //我们可以通过this.表示访问的是类的字段或者方法 
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float Length()
        {
            return (float)Math.Sqrt(x*x+y*y+z*z);
        }

        //定义属性
        //get方法和set方法不要求同时存在
        public int MyIntProperty
        {
            //如果没有get块，就不能取值了
            get
            {
                Console.WriteLine("属性中的get块被调用");
                return 100;
            }
            set
            {
                Console.WriteLine("属性中的set块被调用");
                Console.WriteLine("value的值："+value);
            }
        }
    }
}
