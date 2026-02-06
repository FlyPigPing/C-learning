// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("输入整数：");
//Console.WriteLine();
string str1=Console.ReadLine();
Console.Write("输入整数：");
//Console.WriteLine();
string str2 = Console.ReadLine();
int num1 = Convert.ToInt32(str1);
int num2 = Convert.ToInt32(str2);
int res= num1 + num2;
Console.WriteLine("结果：{0}",res);


