// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//悟空吃桃子,一天吃总数的一半多一个，第n天准备吃的时候刚好剩一个，用户输入n
//int numDay = Convert.ToInt32(Console.ReadLine());
//int sum = 1;
//for (int i = 1; i < numDay; i++)
//{
//    sum = (sum + 1) * 2;
//}
//Console.WriteLine(sum);

//输入n个数，n<100,找出最小数，与最前面的数交换，然后输出
string str = Console.ReadLine();
string[] strArray = str.Split(' ');
int[] num = new int[strArray.Length];
for (int i = 0; i < strArray.Length; i++)
{
    num[i] = Convert.ToInt32(strArray[i]);
}

int min = num[0];
int minIndex = 0;
for (int i = 0; i < num.Length  ; i++)
{
    if (min > num[i])
    {
        min = num[i];//记录最小值
        minIndex = i;//记录最小值的下标
    }
}

//交换
int temp = num[0];
num[0] = num[minIndex];
num[minIndex] = temp;
//输出
foreach (int item in num)
{
    Console.WriteLine(item);
}

