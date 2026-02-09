// See https://aka.ms/new-console-template for more information
using Day5_5_值类型与引用类型;

Console.WriteLine("Hello, World!");


//Test1();
//Test2();
//Test3();
//Test4();
Test5();
static void Test1()
{
    int i = 1;
    int j = 4;
    int temp = 34;
    char c = 'a';
    bool b = true;
}

static void Test2()
{
    int i = 1;
    int j = 4;
    string name = "test";//引用类型
}

static void Test3()
{
    string name1 = "test1";
    string name2 = "test2";
    name1 = name2;//当我们使用引用类型赋值的时候，其实赋值的是引用
    name1 = "google";
    Console.WriteLine(name1 +":"+ name2);
}
static void Test4()
{
    Vector3 v = new Vector3();
    v.x = 100;
}
static void Test5()
{
    Vector3[] vArray = new Vector3[] {new Vector3(),new Vector3(), new Vector3() };
}