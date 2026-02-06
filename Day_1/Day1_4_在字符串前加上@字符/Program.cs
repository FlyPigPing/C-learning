// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string str1 = "U LOVE me\n BUT I DON'T U";
Console.WriteLine(str1);
Console.WriteLine("\n");
//@不识别所有转义字符，除了\"
//""="
string str2 = @"U LOVE me\n"" 
              BUT I DON'T U";
Console.WriteLine(str2);
Console.WriteLine("\n");

//路径的使用
string path = "C:\\xx\\xx\\xx.doc";
Console.WriteLine(path);
Console.WriteLine("\n");
string path2 = @"C:\xx\xx\xx.doc";
Console.WriteLine(path2);


