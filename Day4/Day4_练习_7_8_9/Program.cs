// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//用递归的方法求5！
//f(n)=n*f(n-1)
//int res = Factorial(5);
//Console.WriteLine(res);
//static int Factorial(int num)
//{
//    if (num == 1) return 1;

//    return num*Factorial(num - 1);
//}

//定义学生结构类型，用赋值语句赋值并输出
//Student student;
//student.studentID = 1;
//student.name = "Test";
//student.isGril = true;
//student.scores = 90;
//student.Show();
////Console.WriteLine("ID:" + student.studentID);
////Console.WriteLine("姓名:" + student.name);
////Console.WriteLine("性别:" + student.isGril);
////Console.WriteLine("分数:" + student.scores);
//public struct Student
//{
//    public int studentID;
//    public string name;
//    public bool isGril;
//    public int scores;
//    public void Show()
//    {
//        Console.WriteLine("ID:" + studentID + "姓名:" + name
//                          + "性别:" + (isGril?"女":"男")+ "分数:" + scores);
//    }

//}

//输入正数，对该数进行四舍五入
double num = Convert.ToDouble(Console.ReadLine());
//int res = (int)(num * 10);
int res = (int)(num + 0.5f);
Console.WriteLine("结果：{0}", res);
////Console.WriteLine(res);
//res %= 10;
//if (res >= 5)
//{
//    Console.WriteLine("结果：{0}", (int)num + 1);
//}
//else
//{
//    // Console.WriteLine("111");
//    Console.WriteLine("结果：{0}", (int)num);
//}
