// See https://aka.ms/new-console-template for more information
using Day5_2_面向对象编程_结构化编程_;

Console.WriteLine("Hello, World!");

//如果使用一个类，要先引入命名空间。

Customer customer;//声明一个变量（对象）
//我们自己定义的类，需要我们自己初始化后才可以使用（struct就不用自己初始化）
customer = new Customer();
customer.name = "test";

Console.WriteLine(customer.name);
customer.Show();

