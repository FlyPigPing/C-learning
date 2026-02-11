// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var scoreList = new List<int>();

scoreList.Add(10);
scoreList.Add(20);
scoreList.Add(30);
scoreList.Add(40);
scoreList.Add(50);

//for (int i = 0; i < scoreList.Count; i++)
//{
//    Console.Write(scoreList[i]);
//    Console.WriteLine();
//}

foreach (var temp in scoreList)
{
    Console.Write(temp);
}