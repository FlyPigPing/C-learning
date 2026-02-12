// See https://aka.ms/new-console-template for more information
using Day8_4_XML操作;
using System.Xml;

Console.WriteLine("Hello, World!");

//创建技能信息集合，用来存储所有的技能信息
List<Skill> skillList = new List<Skill>();

///XmlDocument专门用来解析xml文档的
XmlDocument xmlDox = new XmlDocument();
//方法一：选择要加载解析的xml文档的名字
xmlDox.Load("skillinfo.txt");
//方法二：传递一个字符串
//xmlDox.LoadXml(File.ReadAllText("skillinfo.txt"));

//得到根节点(xmlnode用来代表一个节点)
XmlNode rootNode = xmlDox.FirstChild;//获取第一个节点，即skills

//获取根节点下所有子节点的集合，返回节点的集合
XmlNodeList skillNodeList = rootNode.ChildNodes;

foreach (XmlNode skillNode in skillNodeList)
{
    Skill skill = new Skill();

    //
    //也可以通过索引器找，
    //例如：
    //Xmlelement ele = skillNode["id"];//返回节点
    //skill.Id = Int32.Parse(ele.InnerText);


    //获取skill节点下面的所有节点
    XmlNodeList fieldNodeList = skillNode.ChildNodes;
    foreach (XmlNode fieldNode in fieldNodeList)
    {
        if (fieldNode.Name == "id")//通过Name属性 可以获取节点的名字
        {
            int id = Int32.Parse(fieldNode.InnerText);//获取节点内部的文本,然后转化为int类型
            skill.Id = id;
        }else if (fieldNode.Name == "name")
        {
            string name = fieldNode.InnerText;
            skill.Name = name;

            //也可以这样，XmlAttributeCollection col = fieldNode.Attributes;//获取该节点属性的集合
            //           1.//skill.Lang = col["lang"].Value
            //           2.//XmlAttribute langAttribute = col["lang"];
            //             //skill.Lang = langAttribute.Value
            skill.Lang = fieldNode.Attributes[0].Value;//获取属性的集合（Attributes），然后访问第一个属性
                                   //.name可以访问属性的名字，.value可以访问属性的值
        }
        else
        {
            skill.Damage = Int32.Parse(fieldNode.InnerText);
        }
    }
    skillList.Add(skill);
}

foreach (Skill skill in skillList)
{
    Console.WriteLine(skill);//自动调用ToString()方法
}

