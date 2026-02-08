// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//委托是存储函数引用的类型
//委托的定义指定了一个返回类型和一个参数列表
//委托指向一个函数

//定义一个委托，和函数差不多，区别在于
//1.定义委托需要加上关键字delegate
//2.委托的定义不需要函数体

MyDelegate de;//利用定义的委托类型，声明一个变量
              //委托指向一个函数
de = Multipy;//当我们给委托变量赋值的时候，
             //返回值（double）和参数列表（double param1, double param2）
             //必须一样，否则无法赋值
Console.WriteLine(de(2.5,2.5));
de = Divide;
Console.WriteLine(de(2.5, 2.5));
static double Multipy(double param1, double param2)
{
    return param1 * param2;
}
static double Divide(double param1, double param2)
{
    return param1 / param2;
}

public delegate double MyDelegate(double param1,double param2);


