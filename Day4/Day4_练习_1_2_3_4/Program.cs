// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//下列，不是字符常量的是（B）
//A.'\n'B."y"C.'x'
//字符常量是用‘’包裹
//字符串常量是用""包裹

//n>=2
//函数递归
//int res = F(40);
//Console.WriteLine(res);
//static int F(int n)//递归调用
//{
//    if(n==1) return 2;
//    if(n==2) return 3;
//    return F(n-1)+F(n-2);
//}

////将一个整数分解质因数
//// 输入要分解的整数
//int num = 90;
//Console.Write($"{num} 的质因数分解结果：");

//// 核心分解逻辑
//for (int i = 2; i <= num; i++)
//{
//    // 只要i能整除当前num，就说明i是质因数
//    while (num % i == 0)
//    {
//        Console.Write(i + (num == i ? "" : "×")); // 最后一个因数不加×
//        num /= i; // 除以当前质因数，继续分解剩余部分
//    }
//}

//求最大公约数与公倍数
// 定义两个正数
Console.WriteLine("输入m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("输入n");
int n = Convert.ToInt32(Console.ReadLine());

// 求最大公约数
int num1 = m, num2 = n;
while (num2 != 0) 
{ 
    int temp = num2; 
    num2 = num1 % num2; 
    num1 = temp; 
}
int gcd = num1; // 最终a就是最大公约数

// 求最小公倍数（公式：两数乘积 ÷ 最大公约数）
int lcm = m * n / gcd;

// 输出结果
Console.WriteLine($"最大公约数：{gcd}");
Console.WriteLine($"最小公倍数：{lcm}");


