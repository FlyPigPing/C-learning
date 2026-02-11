// See https://aka.ms/new-console-template for more information
using Day7_3_泛型类;

//Console.WriteLine("Hello, World!");

var o1 = new ClassA<int,float>(12, 34,2.33f);//当我们用泛型类构造的时候，需要制定泛型类型
string s = o1.GetSum();

Console.WriteLine(s);
Console.WriteLine(GetSum<int,int,int,int>(2,3));
Console.WriteLine(GetSum<float, float, float, float>(2.2f, 3.3f));
Console.WriteLine(GetSum<string, string, string, string>("ajkda", "123"));



static string GetSum<T,T1,T2,T3>(T a, T b)
{
    return a + " " + b;
}