// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//水仙花数
//for (int i = 100; i < 1000; i++)
//{
//    int third = i % 10;
//    int second = i % 100 / 10;
//    int first = i / 100;
//    int res = (first * first * first) + (second * second * second) + (third * third * third);
//    if(res == i)
//    {
//        Console.WriteLine("水仙花数：" + i );
//    }
//}

//3个可乐瓶换一瓶可乐，现有364瓶可乐，一共可以喝多少可乐，换多少空瓶？
//可以使用
int sum = 364;//有多少可乐
int numEmpty = sum;//有多少空瓶
while (numEmpty >= 3)
{
    sum += numEmpty / 3;//空瓶兑换
    numEmpty = numEmpty % 3 + numEmpty / 3;//空瓶剩余
}
Console.WriteLine("可乐：" + sum + "\t可乐瓶:" + numEmpty);

