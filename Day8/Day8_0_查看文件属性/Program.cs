//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

////相对路径：就是找当前程序所在的路径
////FileInfo fileInfo = new FileInfo("TextFile1.txt");

////绝对路径：文件完整的路径名
//FileInfo fileInfo = new FileInfo("D:\\Code\\C#_C_C++\\C#learning\\Day8\\Day8_0_查看文件属性\\TextFile1.txt");
////判断该文件是否存在
//Console.WriteLine(fileInfo.Exists);
////取得名字,文件名.后缀
//Console.WriteLine(fileInfo.Name);
////查看文件所在路径
//Console.WriteLine(fileInfo.Directory);
////获取文件大小，单位：字节
//Console.WriteLine(fileInfo.Length);
////判断当前是否仅仅是可读的
//Console.WriteLine(fileInfo.IsReadOnly);

//文件删除,删除的是输出路径下的文件，工程下的文件还是存在的
//fileInfo.Delete();
//表示把这个文件复制到另外一个目录，不输入路径，就复制到当前目录下
//fileInfo.CopyTo("tt.txt");

//FileInfo fileInfo = new FileInfo("test.txt");
////if (fileInfo.Exists == false)
////{
////    //创建当前文件
////    fileInfo.Create();
////}
////把文件以这个名字移动到另外一个目录
//fileInfo.MoveTo("test2.txt");//没写路径，复制到当前目录，相当于重命名

//文件夹操作
using System.IO;
//相对路径创建
//DirectoryInfo dirInfo = new DirectoryInfo("test2");
//if (dirInfo.Exists == false)
//{
//    //创建当前目录
//    dirInfo.Create();
//}
//绝对路径创建
DirectoryInfo dirInfo = new DirectoryInfo("D:\\Code\\C#_C_C++\\C#learning\\Day8\\Day8_0_查看文件属性\\bin\\Debug\\net8.0");//查看net8.0文件信息
//判断文件夹是否存在
Console.WriteLine(dirInfo.Exists);
Console.WriteLine(dirInfo.Name);
//查看它的父目录
Console.WriteLine(dirInfo.Parent);
//查看它的根目录
Console.WriteLine(dirInfo.Root);

//创建子目录,test
dirInfo.CreateSubdirectory("test");
;


