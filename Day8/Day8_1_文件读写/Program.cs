// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//读取文本文件
//读取每一行，以换行符进行分割，返回string类的数组
//string[] strArray = File.ReadAllLines("TextFile1.txt");

//foreach (var item in strArray)
//{
//    Console.WriteLine(item);
//}

////读取每一行，返回string类
//string s = File.ReadAllText("TextFile1.txt");
////为什么会有换行，因为里面会有换行符
//Console.WriteLine(s);

//读取非文本文件（图片）
//byte[] byteArray = File.ReadAllBytes("xxx.png");
//foreach (var item in byteArray)
//{
//    Console.WriteLine(item);
//}

//写文件
//在当前运行目录下，创建该文件，写入"你好世界"。
//这些方法写入文件，会把当前文件内容删掉，再进行写入
//File.WriteAllText("FileText2.txt","你好世界");
//File.WriteAllLines("FileText3.txt",new string[] {"w","ww","wayuduay"});
//读取再写入，相当于进行一个复制，只是名字不一样了
//byte[] data = File.ReadAllBytes("xxx.png");
//File.WriteAllBytes("test.png", data);

