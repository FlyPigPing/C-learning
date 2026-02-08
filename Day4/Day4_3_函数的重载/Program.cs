// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//函数名相同，参数不同
//叫做函数的重载
//编译器通过参数的不同，调用不同的方法

int res = MaxHelper.MaxValue(234,4,56,3);
double res2 = MaxHelper.MaxValue(23.4,5.43,6,45);
Console.WriteLine(res);
Console.WriteLine(res2);

//顶级语句模式下，C# 不支持同名的局部函数重载，导致编译器把两个 MaxValue 当成了重复定义。
//想要实现重载，有三个方法：
//方法一：退回传统写法，从 “局部函数” 改成 “类的成员方法”
//方法二:写一个泛型方法，替代两个重载方法，既保留顶级语句，又避免名字冲突
//泛型目前没怎么了解过，不太清楚，虽然在Java中见到过，但自己还是不太会
//方法三:把方法封装到静态类，本质上还是从 “局部函数” 改成 “类的成员方法”
//下面就是方法三的实现。
// 定义静态类，把重载方法放进去（类的成员方法支持重载）
static class MaxHelper
{
    public static int MaxValue(params int[] array)
    {
        Console.WriteLine("int类型的被调用");
        int maxValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
                maxValue = array[i];
        }
        return maxValue;
    }


    public static double MaxValue(params double[] array)
    {
        Console.WriteLine("double类型的被调用");
        double maxValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
                maxValue = array[i];
        }
        return maxValue;
    }
}
