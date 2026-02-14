// See https://aka.ms/new-console-template for more information
using Day9_0_json操作;
using LitJson;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");


//使用litjson解析json文件
//两种方式引入json
//1.去litjson官网下载litjson.dll,然后添加引用
//2.右键，打开管理netget程序包，搜索litjson，在搜索结果中选择一个点击安装
//List < Skill> listSkill = new List < Skill>();
//使用JsonMapper解析json文本
//jsondata对象代表一个数组或者一个对象
//在这里jsonData代表一个数组（存放对象的数组）
//JsonData jsonData = JsonMapper.ToObject(File.ReadAllText("json技能信息.json"));
////在这里item代表一个对象
//foreach (JsonData item in jsonData)
//{
//    Skill skill = new Skill();
//    JsonData idValue = item["id"];//通过字符串索引器可以取得建值对的值,返回的是字符串，需要转换类型
//    JsonData nameValue = item["name"];//通过字符串索引器可以取得建值对的值
//    JsonData DamageValue = item["damage"];//通过字符串索引器可以取得建值对的值

//    int id = Int32.Parse(idValue.ToString());
//    int damage = Int32.Parse(DamageValue.ToString());

//    //Console.WriteLine(id + ":" + nameValue.ToString() + ":" + damage);
//    skill.Id = id;
//    skill.Name = nameValue.ToString();
//    skill.Damage = damage;
//    listSkill.Add(skill);
//}

//foreach (var item in listSkill)
//{
//    Console.WriteLine(item);
//}


//使用泛型去解析json，自己进行初始化
//json里面对象的键必须和定义类里面的字段或者属性保持一致
//使用此方法不能直接用getset方法使编译器自己创建字段
//需要自己写里面的对象，然后字段一一对应，这个泛型才能解析，否则它会找不到
//Skill[] skillArray =  JsonMapper.ToObject<Skill[]>(File.ReadAllText("json技能信息.json"));

//foreach (var item in skillArray)
//{
//    Console.WriteLine(item);
//}

//任何使用数组的地方都可以用List集合替代
//List<Skill> skillList = JsonMapper.ToObject<List<Skill>>(File.ReadAllText("json技能信息.json"));

//foreach (var item in skillList)
//{
//    Console.WriteLine(item);
//}


////把json文本转换成一个对象
//Player player = JsonMapper.ToObject<Player>(File.ReadAllText("主角信息.json"));

//Console.WriteLine(player);

////相当于调用了Skill类里面的ToString方法
//foreach (var item in player.SkillList)
//{
//    Console.WriteLine(item);
//}

//把一个对象转换成json文本
Player player = new Player();
player.Name = "亚瑟";
player.Level = 1;
player.Age = 18;
//把一个对象转换为字符串
string json = JsonMapper.ToJson(player);
Console.WriteLine(json);


