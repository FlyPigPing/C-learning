// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//有关系式1*1+2*2+3*3+...+k*k<2000,计算k的最大值
//int num = 2000;
//int res = 0;
//for (int i = 1; i <= num; i++)
//{
//    res += i * i;
//    if (res > num)
//    {
//       // Console.WriteLine(k);
//        res = res - i * i;
//        break;
//    }
//}
//Console.WriteLine("k的最大值："+res);

//买鸡问题，100元买100只，公：5，母：3，小鸡一元三只
//300：300
//15，9，1


for (int i = 0; i < 100/5; i++)//买到公鸡的个数
{
    for (global::System.Int32 j = 0; j < (100-i*5)/3; j++)//买母鸡的个数
    {
        int remainMoney = 100 - 5 * i - 3 * j;
        int number = remainMoney * 3;//买小鸡
        if ((i + j + number) == 100)
        {
            Console.WriteLine("公鸡:"+i+"\n母鸡："+j+"\n小鸡:"+number);
            Console.WriteLine("--------------------------------------");
        }
    }
}
