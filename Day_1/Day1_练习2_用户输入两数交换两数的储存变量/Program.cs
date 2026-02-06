// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("输入整数：");
//Console.WriteLine();
string str1 = Console.ReadLine();
Console.Write("输入整数：");
//Console.WriteLine();
string str2 = Console.ReadLine();
int num1 = Convert.ToInt32(str1);
int num2 = Convert.ToInt32(str2);
Console.WriteLine("交换前：\nnum1:{0}\nnum2:{1}",num1,num2);
int temp = 0;
temp = num1;
num1 = num2;
num2 = temp;
Console.WriteLine("交换后：\nnum1:{0}\nnum2:{1}", num1, num2);
