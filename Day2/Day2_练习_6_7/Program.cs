// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//统计1~100中能被3整除但是不能被5整除的数，然后输出这些数
//int index = 0;
//int num = 0;
//while (index<=100)
//{
//    index += 3;
//    if (index % 5 == 0) continue;
//    num++;
//    Console.WriteLine("第"+num+"个数是：{0}",index);
//}
//Console.WriteLine("总数是：{0}",num);

//输出1~1000以内所有素数
int index = 0;
while (index<1000)
{
    index++;
    if (index % 2 != 0 && index % 3 != 0 && index % 5 != 0)
    {
        Console.WriteLine(index);
    }
}
