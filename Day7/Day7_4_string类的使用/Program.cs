//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//string s = "kjsdakhsk";//使用string类去存储字符串类型
//                       //字符串需要使用双引号""

//int length = s.Length;//它是一个getset方法，（得到）返回字符串长度

//Console.WriteLine(length);

//if (s == "xxx")//比较字符串是否相等
//{
//    Console.WriteLine("same");
//}
//else Console.WriteLine("no same");

//s = "http:" + s;//字符串的拼接

//char read = s[0];//通过索引器，来访问字符

//for (int i = 0; i < s.Length; i++)//遍历字符串
//{
//    Console.WriteLine(s[i]);
//}

//string 是System.String的别名
string s = "a.b.c";
//int res = s.CompareTo("abc");//>0,表示A字符串先于B字符串，例：a = "aecd",b = "accd"，e>c,所以返回数字大于0
//                             //<0,表示B字符串先于A字符串/B字符串为空，例：a = "adcd",b = "afcd"，d<f,所以返回数字小于0
//                             //=0，表示字符串相等
//                             //可用于排序

//string newStr = s.Replace('.', '-');//给定字符，替换字符
////string newStr = s.Replace(".","----");//给定字符串，替换字符串
//Console.WriteLine(newStr);

//string[] strArray = s.Split('.');
//Console.WriteLine(strArray);

//string str = s.Substring(2,1);//表示截取从索引2开始，截取1个字符
//Console.WriteLine(str);

//string str = s.Trim();
//Console.WriteLine(str);

int index = s.IndexOf("b.");//如果包含返回第一次出现的索引
                            //不包含，返回-1

Console.WriteLine(index);
