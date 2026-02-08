// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//球落100米，落地反弹为原高度一半，求第十次，共经过多少米，第十次反弹多高？
//double h = H(100,10);//调用函数
//Console.WriteLine("第十次反弹" + h + "米");

//static double H(double h,int num = 10)
//{
//    double res = h;
//    double distance = h;
//    for (global::System.Int32 i = 1; i <= num; i++)
//    {
//        res = res / 2;//弹起后，高度/2
//        //distance += res;
//        // 前num-1次反弹后会再下落，第num次仅反弹不下落
//        if (i < num)
//        {
//            distance += res * 2; // 反弹上去 + 再次下落，两次距离，求和
//        }
//    }
//    Console.WriteLine("经历：" + distance + "米");
//    return res;
//}

//求1+2！+3！+....+20!的和

int res = Plus(20);
Console.WriteLine("1+2！+3！+....+20!的和："+res);
static int Factorial(int num)
{
    int res = 1;
    if(num <= 0)
    {
        Console.WriteLine("0和负数没有乘阶");
        return 0;
    }
    for (global::System.Int32 i = 1; i <= num; i++)
    {
       res *= i;
    }
    return res;
}

static int Plus(int num)
{
    int res = 0;
    for (global::System.Int32 i = 1; i <= num; i++)
    {
        res += Factorial(i);
    }
    return res;
}