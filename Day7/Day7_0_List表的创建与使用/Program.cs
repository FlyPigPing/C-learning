// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");

//创建一个空的int类型的列表，<>表示列表的存储类型（泛型）
//List<int> scoreList = new List<int>();
//像列表添加数据1，2，3
//List<int> scoreList = new List<int>() { 1,2,3};
//创建一个初始容量为10的列表
//List<string> headers = new List<string>(10);
//感觉List像一个类，需要进行初始化
var scoreList = new List<int>();

scoreList.Add(12);//向列表中插入数据
//列表容量刚开始是0，如果需要存储的元素个数大于0，容量就变为4，接着如果再超出，就变为8，以此类推
Console.WriteLine("capacity:"+scoreList.Capacity+"count:"+scoreList.Count);
scoreList.Add(45);

Console.WriteLine(scoreList[0]);