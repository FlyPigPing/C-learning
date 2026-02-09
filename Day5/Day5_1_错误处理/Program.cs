// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//try catch块，可以有0个或者多个
//try块:可能出现异常的代码; 如果catch的参数不写，则表示发生任何异常都执行这个catch块
//catch块:捕捉异常；
//try
//{
//}
//catch (< exceptionType > e)
//{
//    throw;
//}

//finally块，可以有0个或者1个
//不管是否有错误，都会执行
//finally
//{
//    Console.WriteLine("这里是finally");
//}

//try
//{
//    int[] myArray = { 1, 2, 3, 4 };
//    int myEle = myArray[4];
//}
//catch (IndexOutOfRangeException e)//如果捕捉的异常类型不对，在发生别的类型的异常的时候，依然会终止程序运行
//{
//    Console.WriteLine(e.Message);
//    Console.WriteLine("访问数组越界");
//}

//finally
//{
//    Console.WriteLine("这里是finally");
//}

//用户输入两个数字，可能有非数字类型，处理该异常，并让用户重新输入，输出俩数字和
int num1 = 0, num2 = 0;
while (true)
{
    try
    {
        Console.WriteLine("输入数字1");
        //输入不正确会发生格式化异常
        num1 = Convert.ToInt32(Console.ReadLine());//在try中，如果一行代码出现异常，剩余代码就不会执行
        Console.WriteLine("输入数字2");
        num2 = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch(FormatException e)
    {
        Console.WriteLine("您输入的不是一个整数，请重新输入");

    }
}
int sum = num1 + num2;
Console.WriteLine(sum);



