// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//编程输出九九乘法表
//int length = 9;
//for (int i = 1; i <= length; i++)
//{
//    for (global::System.Int32 j = 1; j <= i; j++)
//    {
//        Console.Write(i + "x" + j + "=" + i * j);
//        Console.Write("\t");
//    }
//    Console.WriteLine();
//}

//掷骰子100次，并打印各个出现的次数
int index = 1;
int one, two, three, four, five, six;
one = 0; two = 0; three = 0; four = 0; five = 0; six = 0;
Random rnd = new Random();
while (index <= 100)
{
    int rand = rnd.Next(1, 7);
    if (rand == 1) one++;
    else if (rand == 2) two++;
    else if (rand == 3) three++;
    else if (rand == 4) four++;
    else if (rand == 5) five++;
    else if (rand == 6) six++;
    index++;
}
Console.WriteLine(one + "\t" + two);
Console.WriteLine(three + "\t" + four);
Console.WriteLine(five + "\t" + six);
