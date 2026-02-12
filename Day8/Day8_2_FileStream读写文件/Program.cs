// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//一般用于读取非文本文件（图片）,用的是字节
//打开文件，如果文件不存在报错
////1.创建文件流，用来操作文件
//FileStream stream = new FileStream("TextFile1.txt",FileMode.Open);
////2.读取或者写入数据
//byte[] data=new byte[1024];//数据容器
////1 byte = 1 字节  1024byte = 1KB 1024KB = 1MB 1024MB = 1GB 1024GB = 1TB
////从0索引的位置填充数据，直到data.Length
////如果length==0,文件就读取完了
//int length = stream.Read(data,0,data.Length);

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine(data[i] + " ");
//}

//完成文件复制
FileStream readStream = new FileStream("xxx.png", FileMode.Open);

FileStream writeStream = new FileStream("copy.png",FileMode.Create);

byte[] data = new byte[1024];
while (true)
{
    int length = readStream.Read(data, 0, data.Length);
    if(length == 0)
    {
        Console.WriteLine("读取结束");
        break;
    }
    else
    {
        //从0索引开始读,直到data.Length
        writeStream.Write(data, 0, length);
    }

}
writeStream.Close();
readStream.Close();