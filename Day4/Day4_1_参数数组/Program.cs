// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//数组参数，需要我们自己定义一个数组传进去
int sum = Sum(new int[]{ 1, 2, 3, 4, 5, 6, 7});
//参数数组，我们可以传递任意多个参数，然后编译器会自动帮我们拼成一个数组
int sum2=Plus(1,2,3,4,5,6,7,8,9,10);
Console.WriteLine(sum);
Console.WriteLine(sum2);
//方式一
static int Sum(int[] array)
{
    int sum = 0;
    for (global::System.Int32 i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

//加入parames 定义为int类型的参数数组
//参数数组作用：帮助我们减少了一个创建数组的过程
static int Plus(params int[] array)
{
    int sum = 0;
    for (global::System.Int32 i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}
