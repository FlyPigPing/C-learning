// See https://aka.ms/new-console-template for more information
using Day6_0_继承;
using System.Diagnostics;

Console.WriteLine("Hello, World!");


//Boss boss = new Boss();
//boss.AI();//继承父类所有的父类成员和函数成员
//boss.Atack();

//enemy enemy;
//enemy = new Boss();//父类声明的对象可以用子类构造
////虽然使用父类进行了声明，但是使用子类构造，所有本质上是一个子类类型，我们可以强制类型转换成子类类型
//Boss boss = (Boss)enemy;
//boss.Atack();

//enemy enemy = new enemy();
//Boss boss = new Boss();
//boss = (Boss)enemy;//一个对象是什么类型，主要看它是通过什么构造的。所以这里不能转为子类

//Boss boss = new Boss();
//enemy enemy = boss;
//boss.AI();

//Boss boss = new Boss();//调用子类方法
//enemy boss = new Boss();//调用父类隐藏方法（少用）
//boss.Move();

//抽象类的使用
//Crow crow = new Crow();
//crow.Fly();

//可以用抽象类声明，但是不可以用它构造
//MyBird myBird = new Crow();
//myBird.Fly();
//MyBird bird = new MyBird();
