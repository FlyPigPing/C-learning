// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//感觉类似于结构体
//结构体是通过.来调用里面的变量
//结构函数是通过.来调用里面的函数
//作用：把固定操作，把他们声明为一个结构函数


CustomerName myName;
myName.fistName = "xxx";
myName.lastName = "XXX";
Console.WriteLine("my name is"+myName.Getname());

Vector3 myVector3;
myVector3.x = 3;
myVector3.y = 3;
myVector3.z = 3;
Console.WriteLine(myVector3.Distance());

public struct CustomerName
{
    public string fistName;//姓
    public string lastName;//名
    public string Getname()
    {
        return fistName+" "+lastName;
    }
}

//声明一个向量、坐标结构体

public struct Vector3
{
    public float x;
    public float y;
    public float z;
    public double Distance()
    {
        return Math.Sqrt(x * x + y * y + z * z);
    }
}

