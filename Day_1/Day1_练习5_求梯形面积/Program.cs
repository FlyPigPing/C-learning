// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("输入梯形上底：");
string str1 = Console.ReadLine();
Console.Write("输入梯形下底：");
string str2 = Console.ReadLine();
Console.Write("输入梯形高：");
string str3 = Console.ReadLine();
int num1 = Convert.ToInt32(str1);
int num2 = Convert.ToInt32(str2);
double num3 = Convert.ToDouble(str3);
double res = (num1 + num2) * num3 / 2;
Console.WriteLine("梯形面积为：{0}", res);