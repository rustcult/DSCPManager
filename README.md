# DSCPManager
# 功能: 通过应用程序名,对应用程序的流量打上DSCP标记
# 平台: Windows x64
# 设计目的: 配合[DAE](https://github.com/daeuniverse/dae) 实现进程级别的代理
# 原理:调用 Powershell 中的 NetQos Module (仅Windows平台可用)
# 界面展示
![img](./img1.png)
# 例子
```
# DAE 规则
# 若DSCP值设定为4 此处填入4 直连指定进程
dscp(4) -> direct
# 若DSCP值设定为5 此处填入5 代理游戏进程
dscp(5) -> game 
```
