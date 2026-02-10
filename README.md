# C-learning
小白的C#学习之路

Day1--Day4：初阶

# github上传正常流程
1. 写代码
2. git add .
3. git commit -m "做了什么"
4. git push
  
# github的分支合并
在VS2022中，远程提交，无法合并；

1. 终端中，切换到 main 分支  
   git checkout main

2. 合并 master（允许无共同历史）  
   git merge master --allow-unrelated-histories

3. 提交合并  
   git commit -m "merge master into main"

4. 推送到远程  
   git push origin main

# 问题汇总（使用的是顶级语句）
Day3 结构体

1.问题描述：在结构体中引用枚举，定义参数会报错。可访问性不一致: 字段类型“Direction”的可访问性低于字段“Path.dir”

解决方法:把枚举设置为pulic；或者把修饰类型改为internal

原因：结构体 Path 是 public 的，其成员的可访问性不能高于自身依赖的类型，internal 访问级别低于 public 且与未显式修饰（默认 internal）的枚举 Direction 匹配。

2.问题描述：在使用函数重载，报错CS0128 重复定义

解决方法：退回传统写法，从 “局部函数” 改成 “类的成员方法”；写一个泛型方法，替代两个重载方法，既保留顶级语句，又避免名字冲突；把方法封装到静态类

原因：顶级语句模式下，C# 不支持同名的局部函数重载，导致编译器把两个 MaxValue 当成了重复定义
