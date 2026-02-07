// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//把一个小类型的数据给大类型
//编译器会自动进行转换，即隐式转换
byte myByte = 123;
int myInt = myByte;

//当把一个大类型的数据给小类型
//需要进行强制类型转换，即显示转换
myByte = (byte)myInt;
