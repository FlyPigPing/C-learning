// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.Write("输入一个三位数的整数：");
string str1 = Console.ReadLine();
int num1 = Convert.ToInt32(str1);
int third = num1 % 10;
int second = (num1 % 100)/10;
int first = num1 / 100;
Console.WriteLine("转换后的结果是：");
Console.WriteLine("{0}{1}{2}", third,second, first);