// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

//判断是否为回文
//string str = Console.ReadLine();
//bool state = true;
//// 只需要遍历字符串的前半部分即可
//for (int i = 0; i < str.Length / 2; i++)
//{
//    // 第i个字符 对比 倒数第i+1个字符
//    if (str[i] != str[str.Length - 1 - i])
//    {
//        state = false;
//        break; // 一旦发现不相等，直接跳出循环，无需继续判断
//    }
//}   
//if (state==true)
//{
//    Console.WriteLine(str+"是回文");
//}
//else
//{
//    Console.WriteLine(str + "不是回文");
//}

//输入安全密码，密码要求，长度大于8小于16
//至少包含三种，1.A~Z    2.a~z   3. 0-9  4.~!@#$%^

    string str = Console.ReadLine();
if (str.Length < 8 || str.Length > 16)
{
    Console.WriteLine("密码长度不符合规则，不安全。");
}
else
{
    bool isHaveUpper = false;
    bool isHaveLower = false;
    bool isHaveNumber = false;
    bool isHaveSpecial = false;
    for (global::System.Int32 i = 0; i < str.Length; i++)
    {
        if (str[i] >= 'A' && str[i] <= 'Z')
        {
            isHaveUpper = true;
        }
        if (str[i] >= 'a' && str[i] <= 'z')
        {
            isHaveLower = true;
        }
        if (str[i] >= '0' && str[i] <= '9')
        {
            isHaveNumber = true;
        }
        if (str[i] == '~' || str[i] == '!' || str[i] == '@' || str[i] == '#'
            || str[i] == '$' || str[i] == '%' || str[i] == '^')
        {
            isHaveSpecial = true;
        }
    }
    int count = 0;
    if (isHaveUpper) count++;
    if (isHaveLower) count++;
    if (isHaveNumber) count++;
    if (isHaveSpecial) count++;
    if (count >= 3)
    {
        Console.WriteLine("这个密码合法");
    }
    else
    {
        Console.WriteLine("这个密码不安全");
    }
}

