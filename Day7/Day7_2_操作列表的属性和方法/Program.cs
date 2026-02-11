// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var scoreList = new List<int>();

scoreList.Add(0);
scoreList.Add(1);
scoreList.Add(2);
scoreList.Add(3);
foreach (var score in scoreList)
{
    Console.Write(score+" ");
}
Console.WriteLine();

scoreList.Insert(1,10);//在索引1的位置插入10
foreach (var score in scoreList)
{
    Console.Write(score + " ");
}
scoreList.RemoveAt(2);//移除2号索引的元素

//int index = scoreList.IndexOf(10);//找到10的索引，如果没找到返回-1
int index = scoreList.LastIndexOf(10);//从List（）最后面开始找元素，没找到返回-1

scoreList.Sort();//从小到大进行排序

foreach (var score in scoreList)
{
    Console.Write(score + " ");
}
