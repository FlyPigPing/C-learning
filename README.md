# C-learning
小白的C#学习之路
# github上传正常流程
1. 写代码
2. git add .
3. git commit -m "做了什么"
4. git push
  
# github的分支合并
1. 切换到 main 分支  
   git checkout main

2. 合并 master（允许无共同历史）  
   git merge master --allow-unrelated-histories

3. 提交合并  
   git commit -m "merge master into main"

4. 推送到远程  
   git push origin main

