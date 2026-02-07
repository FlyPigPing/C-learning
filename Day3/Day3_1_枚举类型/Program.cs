// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//枚举的定义：
//enum<typeName>
//{
//<value1>
//<value2>
//......
//<valueN>
//}
//枚举类型声明：<typeName><varName>;
//枚举类型赋值：<varName>=<typeName>.<value>;
//枚举中的每个值，默认int类型


GameState state = GameState.Start;

if(state == GameState.Start)
{
    Console.WriteLine("当前游戏处于开始状态");
}
Console.WriteLine(state);
int num = (int)state;
Console.WriteLine(num);
enum GameState:byte//修改该枚举类型的存储类型为byte，默认为int
{
    Pause,//默认0
    Failed,//默认1，以此类推
    Success,
    Start
}

