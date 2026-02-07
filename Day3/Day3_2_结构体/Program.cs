// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//结构的定义：
//struct<typeName>
//{
//<memberDeclarations>//结构体成员
//}

//成员的声明:
//<type><name>
//struct Vector3{
//int x;
//int y;
//int z;
//}

Position enemy1Position;//当使用结构体声明，相当于声明结构体中所有变量
//通过.访问结构体中所有变量
enemy1Position.x = 0;
enemy1Position.y = 0;
enemy1Position.z = 0;

Path path1;
path1.dir = Direction.East;
path1.distance = 1000;

//使用结构体，让程序变得更加清晰
//可以把结构体当成，几个类型组成的一个新的类型
//下面的就是使用三个float类型，组成的坐标类型（Position）
struct Position
{
    public float x;
    public float y;
    public float z;
}


enum Direction
{
    West,
    North,
    East,
    South
}

public struct Path
{
    public float distance;
    //如果internal改为public，会报错可访问性不一致
    //需用internal修饰，相当于设置为private
    //仅可为一个项目，内部使用。
    internal Direction dir;
    //如果需要public 需要把枚举类型（Direction），设置为public
}
