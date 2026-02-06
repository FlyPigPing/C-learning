// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int state = 3;
switch (state)
{
    case 0:
        Console.WriteLine("开始");
        break;
    case 1:
        Console.WriteLine("战斗中");
        break;
    case 2:
        Console.WriteLine("暂停");
        break;
    case 3:
        Console.WriteLine("胜利");
        break;
    //case语句放一起，表示同时满足俩个条件，都执行
    case 4:
    case 5:
        Console.WriteLine("失败");
        break;
    default:
        Console.WriteLine("错误");
        break;

}