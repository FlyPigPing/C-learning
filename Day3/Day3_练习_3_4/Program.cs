// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//猜数游戏
//while (true)
//{
//    Console.WriteLine("请0-50之间的数：");
//    //用随机数生成，所要猜的数
//    Random redonm = new Random();
//    int number = redonm.Next(0,51);
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num == number)
//    {
//        Console.WriteLine("猜对了");
//        return;
//    }
//    else if (num > number)
//    {
//        Console.WriteLine("比数大");

//    }
//    else if (num < number)
//    {
//        Console.WriteLine("比数小");
//    }
//    else
//    {
//        Console.WriteLine("输入错误");
//    }
//}

//字符串加密
string str = Console.ReadLine();
string res = "";
foreach (char item in str)
{
    if (item >= 'a' && item < ('a'+26))//大小写判断
    {
        int num = item;//整数转字符
        num += 3;//字符加密
        char temp = (char)num;//整数转字符
        if (temp >= ('a' + 26))
        {
            temp = (char)(temp - 'z' + 'a'-1);//转到a
        }
        res += temp;//拼接字符
    }else if(item >= 'A' && item < ('A' + 26))
    {
        int num = item;//整数转字符
        num += 3;//字符加密
        char temp = (char)num;//整数转字符
        if(temp >= ('A' + 26))
        {
            temp = (char)(temp - 'Z'+'A'-1);
        }
        res += temp;//拼接字符
    }
    else//既不是小写，也不是大写
    {
        res += item;
    }
}
Console.WriteLine(res);

