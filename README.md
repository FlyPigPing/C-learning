# C-learning
小白的C#学习之路
# github上传正常流程
   写代码
     ↓
  git add .
     ↓
git commit -m "做了什么"
     ↓
  it push
  
# github的分支合并
 提交代码，新建分支master；
 因无共同历史，在web网页无法进行合并；
 1.在VS中，使用git merge master --allow-unrelated-histories，来进行和并；
 2.git commit -m "xxxxx"，进行提交
 3.git push origin main

