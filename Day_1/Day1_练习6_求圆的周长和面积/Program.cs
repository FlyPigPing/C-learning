// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("输入圆的半径：");
string str1 = Console.ReadLine();
double num1 = Convert.ToDouble(str1);
double pi = 3.14;
double perimeter = 2 * pi * num1;
double area = pi * num1 * num1;
Console.WriteLine("此圆的周长为：{0}\n面积为：{1}",perimeter,area);
