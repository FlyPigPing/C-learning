// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//文本文件读取流
//StreamReader reader = new StreamReader("TextFile1.txt");

////while (true)
////{
////    //读取一行数据
////    string str = reader.ReadLine();
////    if (str == null) break;
////    Console. WriteLine(str);
////}

////读取所有的字符
////string str = reader.ReadToEnd();
////Console.WriteLine(str);


//while (true)
//{
//    int res  = reader.Read();
//    if (res == -1)
//    {
//        break;
//    }
//    else
//    {
//        //返回支付Asca码，可以强制转为字符
//        Console.WriteLine((char)reader.Read());
//    }

//}
//reader.Close();

//文本文件写入流
//没有此文件会创建此文件，再写入；有，则覆盖写入
StreamWriter writer = new StreamWriter("TextFile2.txt");


while (true)
{
    //接收用户输入数据
    string message = Console.ReadLine();
    if ((message == "q"))
    {
        break;
    }
    //写入字符串/字符数组，没有换行
    //writer.Write(message);
    //写入字符串，有换行
    writer.WriteLine(message);
}
writer.Close();


