// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//输出1~5的平方值
//for
//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine("第"+i+"个数的平方值："+i*i);
//}

//while
//int index = 1;
////while (index <= 5)
////{
////    Console.WriteLine("第" + index + "个数的平方值：" + index * index);
////    index++;
////}

////do...while
//do
//{
//    Console.WriteLine("第" + index + "个数的平方值：" + index * index);
//    index++;
//}
//while (index <= 5);

//用户输入5个大写字母，不满足要求重新输入
while(true)
{
    bool isUp = true;
    Console.WriteLine("请输入5个大写字母：");
    string str = Console.ReadLine();//获得字符串
    for (int i = 0; i < 5; i++)//获取5个字符
    {
        if (str.Length.Equals(5))
        {
            //比较scamall值
            if (str[i] < 'A' || str[i] > 'Z')//str[i]时char型的字符，可以当成一个整数使用
                isUp = false;//不是大写
        }
        else
        {
            Console.WriteLine("你输入的字母不是5个");
            break;
        }
    }

    if (isUp == false)
    {
        Console.WriteLine("你输入有误，请重新输入：");
    }
    else
        break;
}

