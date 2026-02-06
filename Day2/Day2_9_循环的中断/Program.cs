// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//int index = 1;
//while (true)
//{
//    index++;
//    if (index == 5)
//    {
//        continue;//跳出循环，执行下一个循环
//    }
//    if ((index==10))
//    {
//        break;//终止循环
//    }
//    Console.WriteLine(index);


//}
int res=0;
while (true)
{
    //string str = Console.ReadLine();
    //int num = Convert.ToInt32(str);
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 0)
    {
        Console.WriteLine(res);
        break;
    }
    if (num % 2 != 0)
    {
        continue;
    }
    res += num;

}
