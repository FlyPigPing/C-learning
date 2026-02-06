// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.Write("输入第一个整数：");
string str1 = Console.ReadLine();
Console.Write("输入第一个整数：");
string str2 = Console.ReadLine();
Console.Write("输入第一个整数：");
string str3 = Console.ReadLine();
Console.Write("输入第一个整数：");
string str4 = Console.ReadLine();
int num1 = Convert.ToInt32(str1);
int num2 = Convert.ToInt32(str2);
int num3 = Convert.ToInt32(str3);
int num4 = Convert.ToInt32(str4);
int res = num1 * num2 * num3 * num4;
Console.WriteLine("他们的乘积是：{0}",res);
