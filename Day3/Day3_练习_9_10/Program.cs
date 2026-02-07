// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//求钱
//int num = Convert.ToInt32(Console.ReadLine());
//int count100 = num / 100;
//int remain = num % 100;
//int count50 = remain / 50;
//remain = remain % 50;
//int count10 = remain / 10;
//remain = remain % 10;
//int count5 = remain / 5;
//remain = remain % 5;
//int count2 = remain / 2;
//remain = remain % 2;
//Console.WriteLine("100的准备："+count100);
//Console.WriteLine("50的准备：" + count50);
//Console.WriteLine("10的准备：" + count10);
//Console.WriteLine("5的准备：" + count5);
//Console.WriteLine("2的准备：" + count2);
//Console.WriteLine("1的准备：" + remain);

//验证字符串，判断是否是C#合法字符
string str = Console.ReadLine();
bool isRight = true;
if ((str[0] >= 'a'&& str[0] <= 'z')||(str[0] >= 'A' && str[0] <= 'Z') || 
    (str[0] == '_')||(str[0] =='@'))
{

}
else
{
    isRight = false;
}

for (int i = 1; i < str.Length; i++)
{
    if ((str[0] >= 'a' && str[0] <= 'z') || (str[0] >= 'A' && str[0] <= 'Z') ||
        (str[0] == '_') || (str[0] >= '0' && str[0] <= 9))
    {

    }
    else
    { 
        isRight = false; 
    }
}
if (isRight == false)
{
    Console.WriteLine("不是合法字符");
}
else
{
    Console.WriteLine("是合法字符");
}
