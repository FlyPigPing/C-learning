// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
//与string的差别，StringBuilder里面的字符串是可以变的
//1.
//StringBuilder sb = new StringBuilder("abcd");//利用构造函数创建StringBuilder
//2.
//StringBuilder sb = new StringBuilder(20);//把容量设置为20，里面没有数据，占有20的大小
//3.
StringBuilder sb = new StringBuilder("adjha", 30);//初始字符串adjha,容量大小为30
//sb.Append("/xxx");//把此字符串添加到原字符串的后面
//Console.WriteLine(sb.ToString());

//String s = "123";
//s = s + "/xxx";
//Console.WriteLine(s);
//StringBuilder效率比string高

//sb.Insert(0,"1234/");//在0索引的位置插入字符
//Console.WriteLine(sb);
sb.Remove(0,2);//从0开始，移除俩个字符
Console.WriteLine(sb);