// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] scores = { 1, 2, 3, 4, 5, 6, 7, 8 };
//scores.Length;得到数组长度

//for
//for (int i = 0; i < scores.Length; i++)
//{
//    Console.WriteLine(scores[i]);
//}

//while
//int i = 0;
//while (i < scores.Length)
//{
//    Console.WriteLine(scores[i]);
//    i++;
//}

//foreach
//temp = scores[i]
//foreach会依次取到数组中的值，然后赋值给temp，最后执行循环体
//缺点，不知道索引
foreach (int temp in scores)
{
    Console.WriteLine(temp);
}

