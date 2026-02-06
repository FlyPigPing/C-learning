// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

//四个整数求最大和最小
//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//int num3 = Convert.ToInt32(Console.ReadLine());
//int num4 = Convert.ToInt32(Console.ReadLine());

//int numMax = 0, numMin = 99;
//int index = 1;
//while (index<=4)
//{
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (numMax < num)
//    {
//        numMax = num;
//    }
//    if (numMin > num)
//    {
//        numMin = num;
//    }
//    if (index == 4)
//    {
//        Console.WriteLine(numMax + "" + numMin);
//    }
//    index++;
//}

//输入俩个数，然后在输入0-3之间的数，0代表+，1代表-，*代表乘
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
while (true)
{
    int index = 5;
    string str = Console.ReadLine();
    //字符串之间的比较用双引号
    if(str != "*")
    index = Convert.ToInt32(str);
    switch (index)
    {
        case 0:
            Console.WriteLine(num1 + num2);
            break;
        case 1:
            if (num1 >= num2)
                Console.WriteLine(num1 - num2);
            else
                Console.WriteLine(num2 - num1);
            break;
        case 2:
        case 3:
            return;
        default:
            Console.WriteLine(num2 * num1);
            break;

    }
}

