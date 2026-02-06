// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//接收整数n，为正数则输出1~n，负数则返回，0则继续接收整数
//while (true)
//{

//    int n = Convert.ToInt32(Console.ReadLine());
//    if (n > 0)
//    {
//        for (int i = 1 ; i <= n; i++)
//        {
//            Console.Write(i);
//            Console.Write("\t");
//        }
//        Console.Write("\n");
//    }
//    if (n < 0)  return;
//    if (n == 0)  continue;

//}

//求1000之内所有完数，完数是所有因子之和，6=1+2+3；
int sum = 0;
for (int i = 1; i <= 1000; i++)
{
    sum += i;
    Console.WriteLine("第"+i+"完数是："+sum);
}
