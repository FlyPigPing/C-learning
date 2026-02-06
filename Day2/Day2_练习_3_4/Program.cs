// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//求出1~1000之间所有被7整除的整数，并计算和输出每5个的和
//int index = 0;
//int res = 0;
//int sum = 0;
//int i = 1;
//while (index<=1000)
//{
//    index += 7;
//    if (index % 7 == 0)
//    {
//        res += index;
//        sum += index;
//    }
//    if (i % 5 == 0)
//    {
//        Console.WriteLine("第{0}个五个数之和是：{1}", i / 5, res);
//        res = 0;
//    }
//    i++;
//}
//Console.WriteLine("SUM:{0}", sum);

//输出1~100之间的平方与平方根
//double index = 1;
//double res = 0; 
//while (index<=100)
//{
//    Console.WriteLine("第{0}个的平方是：{1}",index, index * index);
//    Console.WriteLine("第{0}个的平方根是：{1}", index, Math.Sqrt(index));
//    index++;
//}

//一对兔子，第三个月开始生一对，接着每个月生一对，计算20个月后有多少兔子？
int month = 1;
int sum = 0;
int temp = 0;
while (month<=20)
{
    if (month % 3 == 0)
    {
        temp = 20 - month + 1;
        sum += temp;
    }
    month++;
}
Console.WriteLine(sum * 2);