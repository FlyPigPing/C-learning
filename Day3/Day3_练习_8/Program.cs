// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//有n个数，已经排好，现在额外给一个数，插入此队列，并使新队列井然有序。
//指针比较好做吧？
int[] numArray = { 1, 2, 3, 4, 5, 8, 9 };
int num = Convert.ToInt32(Console.ReadLine());
int[] numNew = new int[numArray.Length + 1];
//int index = 0;//建立新索引
//bool isInsert = false;
//for (int i = 0; i < numNew.Length; i++)
//{
//    if (i == numArray.Length && isInsert == false)
//    {
//        numNew[i] = num;
//        isInsert = true;
//       break;
//    }

//    if (num <= numArray[index]&& isInsert == false )//判断是否小于，小于就插入
//    {
//        numNew[i] = num;
//        isInsert = true;
//    }
//    else
//    {
//        numNew[i] = numArray[index];
//        index++;
//    }
//}

//感觉这个方法太麻烦了
//直接全部加入，给sort排序
for (int i = 0; i < numNew.Length; i++)
{
    if (i < numArray.Length)
        numNew[i] = numArray[i];
    else
        numNew[i] = num;
}
//Array.Copy(numArray, numNew, numArray.Length);//把数组复制到一个新的数组

numNew[numArray.Length] = num;

Array.Sort(numNew);

for (int i = 0; i < numNew.Length; i++)
{
    Console.Write(numNew[i]+" ");
}
