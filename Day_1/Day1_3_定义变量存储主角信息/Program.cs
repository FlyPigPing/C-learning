// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string name = "xiaofu";
float hp = 100.0f;
int level = 0;
float exp = 356.3f;
Console.WriteLine("****主角****");
Console.WriteLine("名字：{0} ", name);
Console.WriteLine("血量：{0}", hp);
Console.WriteLine("等级：{0}", level);
Console.WriteLine("经验：{0}",exp);
Console.WriteLine("****—主角—****");
//转义字符，\"=",\n=换行,\\=\,\t=四个空格（水平制表符）
Console.WriteLine("名字：\"{0}\"\n血量：{1}\n等级：{2}\n经验：{3}",name,hp,level,exp);
Console.WriteLine("\\,\",1\t2");

//string就是char的数组