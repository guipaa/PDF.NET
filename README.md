PDF.NET Ver 4.5 开源版

开源项目地址：
http://pwmis.codeplex.com/
开源信息介绍：
http://www.cnblogs.com/bluedoctor/archive/2012/09/28/2707093.html
=========================================

开源项目解决方案运行方法：

请打开 PDFNet_WebAppDemo\PDFNet_WebAppDemo.sln 文件运行，需要VS2010。


-----------------------------------------
本解决方案包括2部分：
1，PDF.NET 核心框架组件
  包含截至今天最新的更新，与“会员版本”功能无任何删减。由于是开源版本，故不提供核心组件中的PDF.NET WinForm数据控件。
  框架相关的外围支持工具，包括代码生成器等源码，仅对会员用户提供。
  组件仅需要 .NET 2.0框架运行。

2，PDF.NET数据开发框架之超市管理系统实例程序
------------------------------------------

首先，打开DAL项目Entity目录下面的Sql文件，在本地SqlServer中创建一个名为"SuperMarket"的数据库，然后执行该Sql建表脚本，
接着修改Web.Config对应的连接字符串(默认使用Windows集成登录，不需要修改连接字符串)，最后，就可以运行项目了。



本项目是一个DDD 驱动的项目实例，有关该项目的信息，请参考：

“领域驱动开发”实例之旅（1）--不一样的开发模式
http://www.cnblogs.com/bluedoctor/archive/2011/06/24/2088392.html

3，超市管理系统 管理员账号：
用户名：SuperMarket
密码：PDF.NET


登录系统后添加雇员、收银员、收音机、商品等信息后，就可以开始“营业”了：）

注意：该Demo程序需要IE支持。
********************************************

PDF.NET官网地址：http://www.pwmis.com/sqlmap
有关获取框架完整源码的事宜，请参看官网。


感谢所有支持PDF.NET的会员用户朋友，是他们促成了我做出最终开源的决定，感谢他们的理解和支持！
感谢所有其它支持PDF.NET的朋友。

最后，以此开源项目，祝大家“国庆中秋快乐”！

其它：
PDF.NET Ver 3.0 开源地址：
节前送礼：PDF.NET（PWMIS数据开发框架）V3.0版开源
http://www.cnblogs.com/bluedoctor/archive/2011/09/29/2195751.html


2012.9.28
深蓝医生

本文更新时间：2012.10.9