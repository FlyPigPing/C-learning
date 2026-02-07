// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//数组的声明：
//<baseTyoe>[]<name>
//string str="ABC";str也是个特殊的数组,str[1]=B;

//第一种，初始化方方式
//int[] scores = { 1, 2, 3, 4, 5 };

//第二种，
//int[] scores = new int[10];
//int[] scores;
//scores = new int[10];

//第三种,感觉和第一种差不多
//int[] scores = new int[10] {1,2,3,4,5,6,7,8,9,10};//scores[10]是不存在的，是0-9.
//感觉不如用string
//char[] cahrArray = new char[2];
string[] names = new string[] { "apple", "pitch", "watermallon" };
Console.WriteLine(names[2]);