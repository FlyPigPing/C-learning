// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//输入数字，以空格分隔，实现从小到达排序，最后输出
string str = Console.ReadLine();
string[] strArray = str.Split(' ');//按空格分隔
int[] numArray = new int[strArray.Length];
for (int i = 0; i < strArray.Length; i++)
{
    numArray[i] = Convert.ToInt32(strArray[i]);
}

//Array.Sort(numArray);//对数组小到大排序，不返回结果（快速排序算法）
//冒泡排序
//for (int j = 0; j < numArray.Length - 1; j++)//外层for循环用来控制循环次数
//{
//    for (int i = 0; i < numArray.Length - 1; i++)
//    {
//        //把numArray[i] numArray[i+1]比较最大的放到后面
//        if (numArray[i + 1] < numArray[i])
//        {
//            int temp = numArray[i];
//            numArray[i] = numArray[i + 1];
//            numArray[i + 1] = temp;
//        }
//    }
//}
//优化冒泡排序
for (int j = 0; j < numArray.Length - 1; j++)//外层for循环用来控制循环次数
{
    for (int i = 0; i < numArray.Length - 1 - j; i++)//优化，每次少执行一次，加快执行效率
    {
        //把numArray[i] numArray[i+1]比较最大的放到后面
        if (numArray[i + 1] < numArray[i])
        {
            int temp = numArray[i];
            numArray[i] = numArray[i + 1];
            numArray[i + 1] = temp;
        }
    }
}



//for (int i = 0; i < numArray.Length; i++)
//{
//    Console.WriteLine(numArray[i]);
//}
foreach (int item in numArray)
{
    Console.Write(item+" ");
}


