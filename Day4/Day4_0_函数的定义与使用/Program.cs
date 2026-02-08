// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Write();//函数的调用，括号内写参数
int num1 = 25, num2 = 35;
int res = Plus(num1,num2);//当调用函数的时候，这里传递的参数就是实际参数（实参），实参->形参
Console.WriteLine(res);
int num3 = Convert.ToInt32(Console.ReadLine());
int[] array = GetDivisor(num3);

//数组不能用Console.WriteLine(XX);直接输出
foreach (int temp in array)
{
    Console.Write(temp + " ");
}
int[] array1 = { 477, 234, 445, 54, 3, 46, 23 };
int max = Max(array1);
Console.WriteLine(max);

static void Write()
{
    //这里是函数体，也叫做方法体，可以写0行或者多行代码
    Console.WriteLine("你好");
    //ctrl+d,复制这一行到下一行；

}
//加
static int  Plus(int num1,int num2)//函数定义的时候，参数我们叫做形式参数（形参），即num1.num2，形参的值是不确定的
{
    int sum = num1 + num2;
    return sum;
}
//获取因子
static int[] GetDivisor(int number)//整型参数
{
    int count = 0;
    for (global::System.Int32 i = 1; i < number; i++)
    {
        if (number%i==0)
        {
            count++;
        }
    }
    int[] array = new int[count];
    int index = 0;
    for (global::System.Int32 i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            array[index]  = i;
            index++;
        }
    }
    return array;
}

//取得数组最大值
static int Max(int[] array)//数组参数
{
    int max = array[0];
    for (global::System.Int32 i = 0; i < array.Length; i++)
    {
        if (array[i]>max)
        {
            max = array[i];
        }
    }
    return max;
}





