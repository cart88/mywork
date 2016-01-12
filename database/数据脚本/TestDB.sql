if exists (select * from sysobjects where id = OBJECT_ID('[tb_sys_admin]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_sys_admin]

CREATE TABLE [tb_sys_admin] (
[id] [int]  IDENTITY (1, 1)  NOT NULL,
[count] [nvarchar]  (10) NULL,
[password] [nvarchar]  (40) NULL,
[loginIP] [nvarchar]  (15) NULL,
[loginTime] [datetime]  NULL,
[telephone] [nvarchar]  (11) NULL,
[email] [nvarchar]  (30) NULL,
[sex] [bit]  NULL,
[birthday] [datetime]  NULL,
[createTime] [datetime]  NULL,
[roleid] [tinyint]  NULL,
[adminTag] [tinyint]  NULL,
[AccountState] [tinyint]  NULL,
[PowerLeave] [nvarchar]  (5) NULL)

ALTER TABLE [tb_sys_admin] WITH NOCHECK ADD  CONSTRAINT [PK_tb_sys_admin] PRIMARY KEY  NONCLUSTERED ( [id] )
SET IDENTITY_INSERT [tb_sys_admin] ON

INSERT [tb_sys_admin] ([id],[count],[password],[loginIP],[loginTime],[telephone],[email],[sex],[birthday],[createTime],[roleid],[adminTag],[AccountState],[PowerLeave]) VALUES ( 1,N'admin',N'8c581610fac95907f78680a2422c111b',N'127.0.0.1',N'2013-1-29 16:51:23',N'15151609119',N'zhouzhilong@163.com',1,N'1987-9-20 0:00:00',N'2013-1-28 15:54:58',1,100,10,N'M12')
INSERT [tb_sys_admin] ([id],[count],[password],[loginIP],[loginTime],[telephone],[sex],[birthday],[createTime],[roleid],[adminTag],[AccountState],[PowerLeave]) VALUES ( 3,N'jon',N'8c581610fac95907f78680a2422c111b',N'127.0.0.1',N'2013-1-28 18:16:13',N'13656565621',0,N'1988-1-1 0:00:00',N'2013-1-28 16:18:04',2,10,20,N'M5')

SET IDENTITY_INSERT [tb_sys_admin] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[tb_sys_capital]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_sys_capital]

CREATE TABLE [tb_sys_capital] (
[CapitalID] [int]  IDENTITY (1, 1)  NOT NULL,
[CapitalName] [varchar]  (50) NULL,
[CapitalCode] [int]  NULL,
[DomainID] [int]  NOT NULL)

ALTER TABLE [tb_sys_capital] WITH NOCHECK ADD  CONSTRAINT [PK_tb_sys_capital] PRIMARY KEY  NONCLUSTERED ( [DomainID] )
SET IDENTITY_INSERT [tb_sys_capital] ON

INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 5,N'香港',1,1)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 6,N'澳门',2,2)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 34,N'黑龙江省',17,17)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 18,N'新疆',28,28)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 33,N'青海',56,56)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 27,N'甘肃省',57,57)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 9,N'内蒙古',69,69)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 12,N'宁夏',78,78)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 21,N'河北省',82,82)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 15,N'山西省',84,84)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 10,N'吉林省',103,103)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 31,N'辽宁省',115,115)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 1,N'北京市',125,125)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 3,N'天津市',127,127)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 14,N'山东省',140,140)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 29,N'西藏',150,150)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 11,N'四川省',166,166)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 8,N'云南省',179,179)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 32,N'陕西省',186,186)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 22,N'河南省',189,189)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 25,N'湖北省',211,211)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 4,N'重庆市',212,212)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 26,N'湖南省',218,218)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 30,N'贵州省',227,227)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 19,N'江苏省',244,244)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 13,N'安徽省',248,248)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 2,N'上海市',252,252)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 23,N'浙江省',255,255)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 20,N'江西省',264,264)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 28,N'福建省',276,276)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 7,N'台湾省',280,280)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 16,N'广东省',292,292)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 17,N'广西',295,295)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 24,N'海南省',303,303)

SET IDENTITY_INSERT [tb_sys_capital] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[tb_sys_city]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_sys_city]

CREATE TABLE [tb_sys_city] (
[CityID] [int]  IDENTITY (1, 1)  NOT NULL,
[CityName] [varchar]  (50) NULL,
[CityCode] [int]  NULL,
[DomainID] [int]  NULL)

SET IDENTITY_INSERT [tb_sys_city] ON

INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 1,N'北京市',125,125)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 2,N'上海市',252,252)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 3,N'天津市',127,127)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 4,N'塘沽区',132,127)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 5,N'奉节区',201,212)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 6,N'重庆市',212,212)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 7,N'涪陵区',213,212)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 8,N'香港',1,1)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 9,N'澳门',2,2)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 10,N'台北市',280,280)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 11,N'昭通市',173,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 12,N'丽江市',174,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 13,N'曲靖市',175,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 14,N'保山市',176,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 15,N'大理州',177,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 16,N'楚雄州',178,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 17,N'昆明市',179,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 18,N'瑞丽市',180,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 19,N'玉溪市',181,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 20,N'临沧市',182,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 21,N'思茅市',184,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 22,N'红河州',185,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 23,N'文山州',369,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 24,N'西双版纳州',370,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 25,N'德宏州',371,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 26,N'怒江州',372,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 27,N'迪庆州',373,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 28,N'呼伦贝尔市',4,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 29,N'兴安盟',7,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 30,N'锡林郭勒盟',16,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 31,N'巴彦淖尔市',63,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 32,N'包头市',64,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 33,N'呼和浩特市',69,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 34,N'锡林浩特市',99,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 35,N'通辽市',101,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 36,N'赤峰市',106,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 37,N'乌海市',382,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 38,N'鄂尔多斯市',383,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 39,N'乌兰察布市',384,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 40,N'辽源市',34,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 41,N'通化市',36,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 42,N'白城市',37,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 43,N'松原市',96,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 44,N'长春市',103,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 45,N'吉林市',104,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 46,N'桦甸市',109,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 47,N'延边州',110,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 48,N'集安市',118,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 49,N'白山市',119,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 50,N'四平市',385,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 51,N'甘孜州',162,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 52,N'阿坝州',163,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 53,N'成都市',166,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 54,N'绵阳市',167,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 55,N'雅安市',168,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 56,N'峨眉山市',170,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 57,N'乐山市',171,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 58,N'宜宾市',172,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 59,N'巴中市',199,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 60,N'达州市',200,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 61,N'遂宁市',204,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 62,N'南充市',205,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 63,N'泸州市',216,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 64,N'自贡市',359,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 65,N'攀枝花市',360,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 66,N'德阳市',361,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 67,N'广元市',362,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 68,N'内江市',363,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 69,N'广安市',364,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 70,N'眉山市',365,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 71,N'资阳市',366,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 72,N'凉山州',367,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 73,N'石嘴山市',54,78)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 74,N'银川市',78,78)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 75,N'吴忠市',83,78)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 76,N'固原市',209,78)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 77,N'淮南市',75,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 78,N'马鞍山市',76,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 79,N'淮北市',77,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 80,N'铜陵市',92,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 81,N'滁州市',95,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 82,N'巢湖市',100,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 83,N'池州市',102,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 84,N'宣城市',105,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 85,N'亳州市',238,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 86,N'宿州市',239,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 87,N'阜阳市',241,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 88,N'六安市',242,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 89,N'蚌埠市',243,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 90,N'合肥市',248,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 91,N'芜湖市',249,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 92,N'安庆市',253,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 93,N'黄山市',254,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 94,N'德州市',134,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 95,N'滨州市',135,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 96,N'烟台市',136,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 97,N'聊城市',139,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 98,N'济南市',140,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 99,N'泰安市',141,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 100,N'淄博市',142,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 101,N'潍坊市',143,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 102,N'青岛市',144,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 103,N'济宁市',146,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 104,N'日照市',147,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 105,N'泰山市',156,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 106,N'枣庄市',159,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 107,N'东营市',160,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 108,N'威海市',164,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 109,N'莱芜市',165,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 110,N'临沂市',183,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 111,N'菏泽市',206,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 112,N'长治市',9,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 113,N'晋中市',22,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 114,N'朔州市',70,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 115,N'大同市',72,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 116,N'吕梁市',80,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 117,N'忻州市',81,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 118,N'太原市',84,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 119,N'阳泉市',85,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 120,N'临汾市',88,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 121,N'运城市',93,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 122,N'晋城市',94,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 123,N'五台山市',381,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 124,N'南雄市',235,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 125,N'韶关市',283,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 126,N'清远市',284,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 127,N'梅州市',285,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 128,N'肇庆市',291,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 129,N'广州市',292,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 130,N'河源市',293,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 131,N'汕头市',294,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 132,N'深圳市',296,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 133,N'汕尾市',297,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 134,N'湛江市',300,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 135,N'阳江市',301,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 136,N'茂名市',302,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 137,N'佛冈市',322,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 138,N'梅县市',323,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 139,N'电白市',324,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 140,N'高要市',325,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 141,N'珠海市',330,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 142,N'佛山市',331,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 143,N'江门市',332,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 144,N'东莞市',334,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 145,N'中山市',335,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 146,N'潮州市',336,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 147,N'揭阳市',337,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 148,N'云浮市',338,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 149,N'桂林市',232,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 150,N'河池市',281,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 151,N'柳州市',282,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 152,N'百色市',288,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 153,N'贵港市',289,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 154,N'梧州市',290,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 155,N'南宁市',295,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 156,N'钦州市',298,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 157,N'北海市',299,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 158,N'防城港市',339,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 159,N'玉林市',340,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 160,N'贺州市',341,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 161,N'来宾市',342,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 162,N'崇左市',343,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 163,N'昌吉州',19,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 164,N'克孜勒苏柯尔克孜自治州',20,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 165,N'伊犁州',21,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 166,N'阿拉尔市',23,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 167,N'克拉玛依市',24,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 168,N'博尔塔拉州',27,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 169,N'乌鲁木齐市',28,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 170,N'吐鲁番市',31,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 171,N'阿克苏市',32,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 172,N'石河子市',33,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 173,N'喀什市',35,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 174,N'和田市',39,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 175,N'哈密市',41,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 176,N'奇台市',52,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 177,N'无锡市',43,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 178,N'苏州市',44,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 179,N'盱眙市',45,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 180,N'赣榆市',46,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 181,N'东台市',47,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 182,N'高邮市',53,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 183,N'镇江市',59,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 184,N'泰州市',61,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 185,N'宿迁市',62,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 186,N'徐州市',236,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 187,N'连云港市',237,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 188,N'淮安市',240,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 189,N'南京市',244,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 190,N'扬州市',245,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 191,N'盐城市',246,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 192,N'南通市',247,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 193,N'常州市',250,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 194,N'庐山市',111,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 195,N'玉山市',137,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 196,N'贵溪市',138,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 197,N'广昌市',145,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 198,N'萍乡市',153,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 199,N'新余市',154,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 200,N'宜春市',224,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 201,N'赣州市',234,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 202,N'九江市',258,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 203,N'景德镇市',259,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 204,N'南昌市',264,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 205,N'鹰潭市',265,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 206,N'上饶市',267,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 207,N'抚州市',273,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 208,N'邯郸市',3,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 209,N'衡水市',8,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 210,N'石家庄市',82,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 211,N'邢台市',86,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 212,N'张家口市',120,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 213,N'承德市',121,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 214,N'秦皇岛市',122,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 215,N'廊坊市',126,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 216,N'唐山市',128,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 217,N'保定市',130,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 218,N'沧州市',131,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 219,N'安阳市',89,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 220,N'三门峡市',188,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 221,N'郑州市',189,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 222,N'南阳市',192,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 223,N'周口市',193,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 224,N'驻马店市',197,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 225,N'信阳市',198,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 226,N'开封市',207,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 227,N'洛阳市',228,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 228,N'平顶山市',231,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 229,N'焦作市',251,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 230,N'鹤壁市',260,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 231,N'新乡市',304,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 232,N'濮阳市',305,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 233,N'许昌市',306,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 234,N'漯河市',307,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 235,N'商丘市',308,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 236,N'济源市',309,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 237,N'湖州市',65,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 238,N'嵊州市',66,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 239,N'平湖市',67,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 240,N'石浦市',68,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 241,N'宁海市',71,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 242,N'洞头市',73,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 243,N'舟山市',74,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 244,N'杭州市',255,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 245,N'嘉兴市',256,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 246,N'定海市',257,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 247,N'金华市',261,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 248,N'绍兴市',262,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 249,N'宁波市',263,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 250,N'衢州市',266,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 251,N'丽水市',268,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 252,N'台州市',269,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 253,N'温州市',272,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 254,N'海口市',303,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 255,N'三亚市',344,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 256,N'屯昌市',345,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 257,N'琼海市',346,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 258,N'儋州市',347,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 259,N'文昌市',348,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 260,N'万宁市',349,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 261,N'东方市',350,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 262,N'澄迈市',351,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 263,N'定安市',352,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 264,N'临高市',353,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 265,N'白沙黎族自治县',354,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 266,N'乐东黎族自治县',355,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 267,N'陵水黎族自治县',356,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 268,N'保亭黎族苗族自治县',357,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 269,N'琼中黎族苗族自治县',358,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 270,N'襄樊市',196,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 271,N'荆门市',202,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 272,N'黄冈市',203,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 273,N'恩施州',208,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 274,N'武汉市',211,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 275,N'黄石市',310,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 276,N'鄂州市',314,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 277,N'孝感市',315,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 278,N'咸宁市',316,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 279,N'随州市',317,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 280,N'仙桃市',318,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 281,N'天门市',319,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 282,N'潜江市',320,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 283,N'神农架市',321,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 284,N'张家界市',214,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 285,N'岳阳市',215,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 286,N'怀化市',217,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 287,N'长沙市',218,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 288,N'邵阳市',222,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 289,N'益阳市',223,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 290,N'郴州市',233,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 291,N'桑植市',311,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 292,N'沅陵市',312,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 293,N'南岳市',313,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 294,N'株洲市',326,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 295,N'湘潭市',327,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 296,N'衡阳市',328,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 297,N'娄底市',329,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 298,N'常德市',387,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 299,N'张掖市',49,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 300,N'金昌市',50,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 301,N'武威市',51,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 302,N'兰州市',57,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 303,N'白银市',58,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 304,N'定西市',60,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 305,N'平凉市',90,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 306,N'庆阳市',91,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 307,N'甘南市',225,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 308,N'临夏市',229,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 309,N'天水市',377,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 310,N'嘉峪关市',378,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 311,N'酒泉市',379,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 312,N'陇南市',380,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 313,N'莆田市',107,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 314,N'浦城市',271,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 315,N'南平市',274,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 316,N'宁德市',275,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 317,N'福州市',276,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 318,N'龙岩市',277,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 319,N'三明市',278,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 320,N'泉州市',279,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 321,N'漳州市',286,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 322,N'厦门市',287,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 323,N'那曲地区',148,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 324,N'日喀则地区',149,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 325,N'拉萨市',150,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 326,N'山南地区',151,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 327,N'阿里地区',152,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 328,N'昌都地区',161,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 329,N'林芝地区',169,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 330,N'毕节市',219,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 331,N'遵义市',220,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 332,N'铜仁市',221,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 333,N'安顺市',226,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 334,N'贵阳市',227,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 335,N'黔西南州',230,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 336,N'六盘水市',368,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 337,N'葫芦岛市',25,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 338,N'盘锦市',26,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 339,N'辽阳市',29,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 340,N'铁岭市',30,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 341,N'阜新市',108,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 342,N'朝阳市',112,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 343,N'锦州市',113,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 344,N'鞍山市',114,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 345,N'沈阳市',115,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 346,N'本溪市',116,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 347,N'抚顺市',117,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 348,N'营口市',123,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 349,N'丹东市',124,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 350,N'瓦房店市',129,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 351,N'大连市',133,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 352,N'榆林市',79,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 353,N'延安市',87,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 354,N'西安市',186,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 355,N'渭南市',187,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 356,N'汉中市',190,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 357,N'商洛市',191,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 358,N'安康市',194,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 359,N'铜川市',374,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 360,N'宝鸡市',375,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 361,N'咸阳市',376,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 362,N'海北州',48,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 363,N'海南州',55,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 364,N'西宁市',56,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 365,N'玉树州',155,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 366,N'黄南州',157,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 367,N'果洛州',158,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 368,N'海西州',195,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 369,N'海东市',210,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 370,N'大兴安岭地区',5,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 371,N'黑河市',6,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 372,N'齐齐哈尔市',10,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 373,N'绥化市',11,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 374,N'鹤岗市',12,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 375,N'佳木斯市',13,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 376,N'伊春市',14,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 377,N'双鸭山市',15,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 378,N'哈尔滨市',17,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 379,N'鸡西市',18,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 380,N'漠河市',38,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 381,N'大庆市',40,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 382,N'七台河市',42,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 383,N'牡丹江市',97,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 384,N'绥芬河市',98,17)

SET IDENTITY_INSERT [tb_sys_city] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[tb_sys_distribution]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_sys_distribution]

CREATE TABLE [tb_sys_distribution] (
[id] [int]  IDENTITY (1, 1)  NOT NULL,
[userid] [int]  NULL,
[receiveName] [nvarchar]  (15) NULL,
[postAddress] [nvarchar]  (100) NULL,
[province] [nvarchar]  (8) NULL,
[city] [nvarchar]  (8) NULL,
[telephone] [nvarchar]  (11) NULL,
[phone] [nvarchar]  (15) NULL,
[zipCode] [nvarchar]  (6) NULL,
[addtime] [datetime]  NULL,
[cardNumber] [nvarchar]  (8) NULL,
[deliverytime] [datetime]  NULL,
[ampm] [nvarchar]  (2) NULL,
[remarks] [nvarchar]  (80) NULL)

ALTER TABLE [tb_sys_distribution] WITH NOCHECK ADD  CONSTRAINT [PK_tb_sys_distribution] PRIMARY KEY  NONCLUSTERED ( [id] )
SET IDENTITY_INSERT [tb_sys_distribution] ON

INSERT [tb_sys_distribution] ([id],[userid],[receiveName],[postAddress],[province],[city],[telephone],[zipCode],[addtime],[cardNumber],[deliverytime],[ampm]) VALUES ( 51,1,N'哈哈',N'的非官方的施工方的送',N'四川省',N'成都市',N'15151609119',N'165434',N'2012-10-19 10:09:19',N'19990003',N'2012-10-19 0:00:00',N'上午')
INSERT [tb_sys_distribution] ([id],[userid],[receiveName],[postAddress],[province],[city],[telephone],[zipCode],[addtime],[cardNumber],[deliverytime],[ampm]) VALUES ( 52,1,N'范德萨发',N'范德萨发大厦',N'新疆',N'昌吉州',N'15151609119',N'165456',N'2012-10-19 14:22:29',N'19990004',N'2012-10-20 0:00:00',N'上午')
INSERT [tb_sys_distribution] ([id],[userid],[receiveName],[postAddress],[province],[city],[telephone],[zipCode],[addtime]) VALUES ( 54,1,N'dsafds',N'fdsafdsa',N'重庆市',N'奉节区',N'16546546546',N'135465',N'2013-1-29 11:39:26')

SET IDENTITY_INSERT [tb_sys_distribution] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[tb_sys_paramcenter]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_sys_paramcenter]

CREATE TABLE [tb_sys_paramcenter] (
[id] [int]  IDENTITY (1, 1)  NOT NULL,
[name] [nvarchar]  (50) NULL,
[value] [int]  NULL,
[typeTag] [nvarchar]  (10) NULL,
[addUserId] [int]  NULL,
[addUserName] [nvarchar]  (15) NULL,
[addTime] [datetime]  NULL)

ALTER TABLE [tb_sys_paramcenter] WITH NOCHECK ADD  CONSTRAINT [PK_tb_sys_paramcenter] PRIMARY KEY  NONCLUSTERED ( [id] )
SET IDENTITY_INSERT [tb_sys_paramcenter] ON

INSERT [tb_sys_paramcenter] ([id],[name],[value],[typeTag],[addUserId],[addUserName],[addTime]) VALUES ( 16,N'注册奖励',1,N'积分',1,N'admin',N'2012-6-5 16:55:57')
INSERT [tb_sys_paramcenter] ([id],[name],[value],[typeTag],[addUserId],[addUserName],[addTime]) VALUES ( 17,N'登录奖励',2,N'积分',1,N'admin',N'2012-6-5 16:56:15')
INSERT [tb_sys_paramcenter] ([id],[name],[value],[typeTag],[addUserId],[addUserName],[addTime]) VALUES ( 18,N'购买奖励',3,N'积分',1,N'admin',N'2012-6-5 16:56:24')
INSERT [tb_sys_paramcenter] ([id],[name],[value],[typeTag],[addUserId],[addUserName],[addTime]) VALUES ( 19,N'积分兑换',4,N'积分',1,N'admin',N'2012-6-5 16:56:33')
INSERT [tb_sys_paramcenter] ([id],[name],[value],[typeTag],[addUserId],[addUserName],[addTime]) VALUES ( 20,N'修改减少',5,N'积分',1,N'admin',N'2012-6-5 18:07:36')
INSERT [tb_sys_paramcenter] ([id],[name],[value],[typeTag],[addUserId],[addUserName],[addTime]) VALUES ( 21,N'修改增加',6,N'积分',1,N'admin',N'2012-6-5 18:07:55')

SET IDENTITY_INSERT [tb_sys_paramcenter] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[tb_sys_role]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_sys_role]

CREATE TABLE [tb_sys_role] (
[id] [int]  IDENTITY (1, 1)  NOT NULL,
[roleName] [nvarchar]  (10) NULL,
[pageId] [nvarchar]  (250) NULL,
[addUser] [nvarchar]  (15) NULL,
[addTime] [datetime]  NULL)

ALTER TABLE [tb_sys_role] WITH NOCHECK ADD  CONSTRAINT [PK_tb_sys_role] PRIMARY KEY  NONCLUSTERED ( [id] )
SET IDENTITY_INSERT [tb_sys_role] ON

INSERT [tb_sys_role] ([id],[roleName],[pageId],[addUser],[addTime]) VALUES ( 1,N'超级管理员',N'1,2,12,3,9,10,13,14,15,16,17,18,19,20,21,40,45,53,54,55,56,61,62,63,64,22,23,24,25,26,27,41,28,29,33,51,30,31,32,34,35,36,37,38,39,52,42,43,46,47,48,49,50,57,58,59,60,65,66,67,68,69,70',N'admin',N'2012-9-11 14:13:05')
INSERT [tb_sys_role] ([id],[roleName],[pageId],[addUser],[addTime]) VALUES ( 2,N'网络编辑',N'22,23,24,25,26,27,41',N'admin',N'2013-1-29 11:42:44')
INSERT [tb_sys_role] ([id],[roleName],[addUser],[addTime]) VALUES ( 3,N'会计',N'admin',N'2012-5-23 12:55:19')

SET IDENTITY_INSERT [tb_sys_role] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[tb_sys_sysfiles]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_sys_sysfiles]

CREATE TABLE [tb_sys_sysfiles] (
[id] [int]  IDENTITY (1, 1)  NOT NULL,
[classId] [int]  NULL,
[fielsName] [nchar]  (10) NULL,
[filesUrl] [nvarchar]  (50) NULL,
[filesOrder] [int]  NULL,
[describe] [nvarchar]  (20) NULL,
[showLeft] [bit]  NULL,
[addTime] [datetime]  NULL,
[addUserId] [int]  NULL,
[addUser] [nvarchar]  (15) NULL)

ALTER TABLE [tb_sys_sysfiles] WITH NOCHECK ADD  CONSTRAINT [PK_tb_sys_sysfiles] PRIMARY KEY  NONCLUSTERED ( [id] )
SET IDENTITY_INSERT [tb_sys_sysfiles] ON

INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 1,1,N'菜单列表',N'menu/Manage_Menu.aspx',1,1,N'2012-5-25 15:58:59',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 2,1,N'添加菜单',N'menu/Add_Menu.aspx',2,1,N'2012-5-30 10:31:24',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 3,2,N'页面列表',N'syspage/Manage_Page.aspx',3,1,N'2012-5-25 16:04:46',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 9,2,N'添加文件',N'syspage/Add_Page.aspx',2,1,N'2012-5-26 16:23:27',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 10,2,N'修改文件',N'syspage/Edit_Page.aspx',1,0,N'2012-5-26 16:17:50',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 12,1,N'修改菜单',N'menu/Edit_Menu.aspx',3,0,N'2012-5-25 16:00:20',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 13,3,N'角色列表',N'role/Manage_Role.aspx',1,1,N'2012-5-25 16:07:28',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 14,3,N'新增角色',N'role/Add_Role.aspx',2,1,N'2012-5-25 16:07:22',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 15,3,N'角色修改',N'role/Edit_Role.aspx',3,0,N'2012-5-25 16:07:49',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 16,4,N'系统用户列表',N'sysuser/Manage_SysUser.aspx',1,1,N'2012-5-25 16:27:26',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 17,4,N'新增系统用户',N'sysuser/Add_SysUser.aspx',0,1,N'2012-5-25 16:26:39',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 18,4,N'系统用户修改',N'sysuser/Edit_SysUser.aspx',3,0,N'2012-5-25 16:27:49',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 22,7,N'添加会员',N'member/Add_Member.aspx',1,1,N'2012-5-26 16:29:00',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 23,7,N'会员信息修改',N'member/Edit_Member.aspx',0,0,N'2012-5-26 16:29:46',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 24,7,N'会员列表',N'member/Manage_Member.aspx',1,1,N'2012-5-26 16:30:22',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 25,7,N'配送地址管理',N'member/Manage_Address.aspx',4,1,N'2012-5-26 16:33:23',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 26,7,N'新增配送地址',N'member/Add_Address.aspx',5,1,N'2012-5-26 16:36:14',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 27,7,N'修改配送地址',N'member/Edit_Address.aspx',6,0,N'2012-5-26 16:36:46',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 34,10,N'参数列表',N'sysparam/Manage_SysParam.aspx',1,1,N'2012-6-4 15:50:25',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 35,10,N'新增配置参数',N'sysparam/Add_SysParam.aspx',2,1,N'2012-6-4 15:51:04',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 36,10,N'参数修改',N'sysparam/Edit_SysParam.aspx',3,0,N'2012-6-4 15:52:17',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 41,7,N'会员密码修改',N'member/Edit_Psssword.aspx',7,0,N'2012-6-5 19:09:11',1,N'admin')

SET IDENTITY_INSERT [tb_sys_sysfiles] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[tb_sys_sysmenu]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_sys_sysmenu]

CREATE TABLE [tb_sys_sysmenu] (
[id] [int]  IDENTITY (1, 1)  NOT NULL,
[menuName] [nvarchar]  (10) NULL,
[menuOrder] [int]  NULL,
[imgUrl] [nvarchar]  (50) NULL,
[addName] [nvarchar]  (10) NULL,
[addTime] [datetime]  NULL)

ALTER TABLE [tb_sys_sysmenu] WITH NOCHECK ADD  CONSTRAINT [PK_tb_sys_sysmenu] PRIMARY KEY  NONCLUSTERED ( [id] )
SET IDENTITY_INSERT [tb_sys_sysmenu] ON

INSERT [tb_sys_sysmenu] ([id],[menuName],[menuOrder],[imgUrl],[addName],[addTime]) VALUES ( 1,N'菜单管理',3,N'../Images/Ico/menu.gif',N'admin',N'2012-5-26 16:43:37')
INSERT [tb_sys_sysmenu] ([id],[menuName],[menuOrder],[imgUrl],[addName],[addTime]) VALUES ( 2,N'页面管理',2,N'../Images/Ico/pageChild.gif',N'admin',N'2012-5-26 17:06:03')
INSERT [tb_sys_sysmenu] ([id],[menuName],[menuOrder],[imgUrl],[addName],[addTime]) VALUES ( 3,N'角色管理',4,N'../Images/Ico/anonymous.gif',N'admin',N'2012-5-26 16:43:40')
INSERT [tb_sys_sysmenu] ([id],[menuName],[menuOrder],[imgUrl],[addName],[addTime]) VALUES ( 4,N'系统用户',5,N'../Images/Ico/administrat.gif',N'admin',N'2012-5-26 17:05:06')
INSERT [tb_sys_sysmenu] ([id],[menuName],[menuOrder],[imgUrl],[addName],[addTime]) VALUES ( 7,N'会员管理',1,N'../Images/Ico/memberuser.gif',N'admin',N'2013-1-29 11:41:27')
INSERT [tb_sys_sysmenu] ([id],[menuName],[menuOrder],[imgUrl],[addName],[addTime]) VALUES ( 10,N'系统参数',6,N'../Images/Ico/paramset.gif',N'admin',N'2012-6-4 15:48:38')

SET IDENTITY_INSERT [tb_sys_sysmenu] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[tb_sys_userinfo]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_sys_userinfo]

CREATE TABLE [tb_sys_userinfo] (
[ID] [int]  IDENTITY (1, 1)  NOT NULL,
[userName] [nvarchar]  (10) NULL,
[password] [nvarchar]  (40) NULL,
[trueName] [nvarchar]  (15) NULL,
[currentScore] [int]  NULL,
[totalScore] [int]  NULL,
[sex] [bit]  NULL,
[province] [nvarchar]  (10) NULL,
[city] [nvarchar]  (10) NULL,
[isBusiness] [bit]  NULL,
[registNumber] [nvarchar]  (18) NULL,
[department] [nvarchar]  (10) NULL,
[position] [nvarchar]  (10) NULL,
[phone] [nvarchar]  (11) NULL,
[address] [nvarchar]  (100) NULL,
[addTime] [datetime]  NULL)

ALTER TABLE [tb_sys_userinfo] WITH NOCHECK ADD  CONSTRAINT [PK_tb_sys_userinfo] PRIMARY KEY  NONCLUSTERED ( [ID] )
SET IDENTITY_INSERT [tb_sys_userinfo] ON

INSERT [tb_sys_userinfo] ([ID],[userName],[password],[trueName],[currentScore],[totalScore],[sex],[province],[city],[isBusiness],[phone],[address],[addTime]) VALUES ( 12,N'土豆哥哥',N'8c581610fac95907f78680a2422c111b',N'周土豆',30,30,1,N'浙江省',N'杭州市',0,N'15151609119',N'西湖区文三西路荷花苑',N'2013-1-24 14:38:13')

SET IDENTITY_INSERT [tb_sys_userinfo] OFF
