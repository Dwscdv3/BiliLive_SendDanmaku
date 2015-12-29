# BiliLive_SendDanmaku
功能：向哔哩哔哩直播间发送弹幕，适合播主直播时使用  
  
使用前请到设置里填好直播间号和 Cookie  
在 live.bilibili.com 的任意页面的已登录状态下打开控制台执行 "document.cookie" 即可得到 Cookie 字符串  
  
未yi实qi现keng的功能：  
全局快捷键  
用户名和密码登录  
  
已知问题：  
表单正文使用字符串拼接，但没有转义特殊字符  
API 不支持三位短号，需填写原始编号才能成功发送  
