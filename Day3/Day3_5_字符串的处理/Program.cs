// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string str = "123,I,LOVE,YOU";
//for (int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine(str[i]);
//}

//string res = str.ToLower();//把str里面的字符串，变为小写（lowercase）,并返回
//string res = str.ToUpper();//转为大写（uppercase)
//string res = str.Trim();//移除字符串，前后的空格，中间的空格不管
//string res = str.TrimStart();//移除字符串前的空格
//string res = str.TrimEnd();//移除字符串后的空格
string[] strArray = str.Split(',');//把字符串按照‘，’进行拆分，并返回一个string类数组
Console.WriteLine(str);
foreach (string item in strArray)
{
    Console.WriteLine(item);
}
//Console.WriteLine(res);

