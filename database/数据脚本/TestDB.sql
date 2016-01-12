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

INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 5,N'���',1,1)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 6,N'����',2,2)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 34,N'������ʡ',17,17)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 18,N'�½�',28,28)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 33,N'�ຣ',56,56)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 27,N'����ʡ',57,57)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 9,N'���ɹ�',69,69)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 12,N'����',78,78)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 21,N'�ӱ�ʡ',82,82)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 15,N'ɽ��ʡ',84,84)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 10,N'����ʡ',103,103)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 31,N'����ʡ',115,115)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 1,N'������',125,125)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 3,N'�����',127,127)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 14,N'ɽ��ʡ',140,140)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 29,N'����',150,150)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 11,N'�Ĵ�ʡ',166,166)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 8,N'����ʡ',179,179)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 32,N'����ʡ',186,186)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 22,N'����ʡ',189,189)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 25,N'����ʡ',211,211)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 4,N'������',212,212)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 26,N'����ʡ',218,218)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 30,N'����ʡ',227,227)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 19,N'����ʡ',244,244)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 13,N'����ʡ',248,248)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 2,N'�Ϻ���',252,252)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 23,N'�㽭ʡ',255,255)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 20,N'����ʡ',264,264)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 28,N'����ʡ',276,276)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 7,N'̨��ʡ',280,280)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 16,N'�㶫ʡ',292,292)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 17,N'����',295,295)
INSERT [tb_sys_capital] ([CapitalID],[CapitalName],[CapitalCode],[DomainID]) VALUES ( 24,N'����ʡ',303,303)

SET IDENTITY_INSERT [tb_sys_capital] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[tb_sys_city]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_sys_city]

CREATE TABLE [tb_sys_city] (
[CityID] [int]  IDENTITY (1, 1)  NOT NULL,
[CityName] [varchar]  (50) NULL,
[CityCode] [int]  NULL,
[DomainID] [int]  NULL)

SET IDENTITY_INSERT [tb_sys_city] ON

INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 1,N'������',125,125)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 2,N'�Ϻ���',252,252)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 3,N'�����',127,127)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 4,N'������',132,127)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 5,N'�����',201,212)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 6,N'������',212,212)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 7,N'������',213,212)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 8,N'���',1,1)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 9,N'����',2,2)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 10,N'̨����',280,280)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 11,N'��ͨ��',173,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 12,N'������',174,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 13,N'������',175,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 14,N'��ɽ��',176,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 15,N'������',177,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 16,N'������',178,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 17,N'������',179,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 18,N'������',180,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 19,N'��Ϫ��',181,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 20,N'�ٲ���',182,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 21,N'˼é��',184,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 22,N'�����',185,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 23,N'��ɽ��',369,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 24,N'��˫������',370,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 25,N'�º���',371,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 26,N'ŭ����',372,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 27,N'������',373,179)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 28,N'���ױ�����',4,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 29,N'�˰���',7,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 30,N'���ֹ�����',16,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 31,N'�����׶���',63,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 32,N'��ͷ��',64,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 33,N'���ͺ�����',69,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 34,N'���ֺ�����',99,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 35,N'ͨ����',101,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 36,N'�����',106,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 37,N'�ں���',382,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 38,N'������˹��',383,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 39,N'�����첼��',384,69)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 40,N'��Դ��',34,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 41,N'ͨ����',36,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 42,N'�׳���',37,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 43,N'��ԭ��',96,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 44,N'������',103,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 45,N'������',104,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 46,N'�����',109,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 47,N'�ӱ���',110,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 48,N'������',118,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 49,N'��ɽ��',119,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 50,N'��ƽ��',385,103)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 51,N'������',162,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 52,N'������',163,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 53,N'�ɶ���',166,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 54,N'������',167,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 55,N'�Ű���',168,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 56,N'��üɽ��',170,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 57,N'��ɽ��',171,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 58,N'�˱���',172,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 59,N'������',199,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 60,N'������',200,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 61,N'������',204,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 62,N'�ϳ���',205,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 63,N'������',216,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 64,N'�Թ���',359,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 65,N'��֦����',360,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 66,N'������',361,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 67,N'��Ԫ��',362,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 68,N'�ڽ���',363,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 69,N'�㰲��',364,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 70,N'üɽ��',365,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 71,N'������',366,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 72,N'��ɽ��',367,166)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 73,N'ʯ��ɽ��',54,78)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 74,N'������',78,78)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 75,N'������',83,78)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 76,N'��ԭ��',209,78)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 77,N'������',75,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 78,N'��ɽ��',76,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 79,N'������',77,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 80,N'ͭ����',92,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 81,N'������',95,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 82,N'������',100,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 83,N'������',102,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 84,N'������',105,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 85,N'������',238,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 86,N'������',239,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 87,N'������',241,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 88,N'������',242,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 89,N'������',243,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 90,N'�Ϸ���',248,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 91,N'�ߺ���',249,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 92,N'������',253,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 93,N'��ɽ��',254,248)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 94,N'������',134,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 95,N'������',135,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 96,N'��̨��',136,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 97,N'�ĳ���',139,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 98,N'������',140,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 99,N'̩����',141,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 100,N'�Ͳ���',142,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 101,N'Ϋ����',143,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 102,N'�ൺ��',144,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 103,N'������',146,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 104,N'������',147,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 105,N'̩ɽ��',156,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 106,N'��ׯ��',159,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 107,N'��Ӫ��',160,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 108,N'������',164,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 109,N'������',165,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 110,N'������',183,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 111,N'������',206,140)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 112,N'������',9,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 113,N'������',22,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 114,N'˷����',70,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 115,N'��ͬ��',72,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 116,N'������',80,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 117,N'������',81,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 118,N'̫ԭ��',84,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 119,N'��Ȫ��',85,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 120,N'�ٷ���',88,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 121,N'�˳���',93,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 122,N'������',94,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 123,N'��̨ɽ��',381,84)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 124,N'������',235,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 125,N'�ع���',283,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 126,N'��Զ��',284,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 127,N'÷����',285,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 128,N'������',291,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 129,N'������',292,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 130,N'��Դ��',293,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 131,N'��ͷ��',294,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 132,N'������',296,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 133,N'��β��',297,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 134,N'տ����',300,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 135,N'������',301,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 136,N'ï����',302,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 137,N'�����',322,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 138,N'÷����',323,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 139,N'�����',324,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 140,N'��Ҫ��',325,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 141,N'�麣��',330,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 142,N'��ɽ��',331,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 143,N'������',332,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 144,N'��ݸ��',334,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 145,N'��ɽ��',335,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 146,N'������',336,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 147,N'������',337,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 148,N'�Ƹ���',338,292)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 149,N'������',232,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 150,N'�ӳ���',281,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 151,N'������',282,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 152,N'��ɫ��',288,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 153,N'�����',289,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 154,N'������',290,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 155,N'������',295,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 156,N'������',298,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 157,N'������',299,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 158,N'���Ǹ���',339,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 159,N'������',340,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 160,N'������',341,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 161,N'������',342,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 162,N'������',343,295)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 163,N'������',19,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 164,N'�������տ¶�����������',20,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 165,N'������',21,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 166,N'��������',23,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 167,N'����������',24,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 168,N'����������',27,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 169,N'��³ľ����',28,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 170,N'��³����',31,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 171,N'��������',32,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 172,N'ʯ������',33,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 173,N'��ʲ��',35,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 174,N'������',39,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 175,N'������',41,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 176,N'��̨��',52,28)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 177,N'������',43,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 178,N'������',44,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 179,N'������',45,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 180,N'������',46,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 181,N'��̨��',47,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 182,N'������',53,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 183,N'����',59,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 184,N'̩����',61,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 185,N'��Ǩ��',62,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 186,N'������',236,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 187,N'���Ƹ���',237,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 188,N'������',240,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 189,N'�Ͼ���',244,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 190,N'������',245,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 191,N'�γ���',246,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 192,N'��ͨ��',247,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 193,N'������',250,244)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 194,N'®ɽ��',111,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 195,N'��ɽ��',137,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 196,N'��Ϫ��',138,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 197,N'�����',145,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 198,N'Ƽ����',153,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 199,N'������',154,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 200,N'�˴���',224,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 201,N'������',234,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 202,N'�Ž���',258,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 203,N'��������',259,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 204,N'�ϲ���',264,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 205,N'ӥ̶��',265,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 206,N'������',267,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 207,N'������',273,264)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 208,N'������',3,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 209,N'��ˮ��',8,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 210,N'ʯ��ׯ��',82,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 211,N'��̨��',86,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 212,N'�żҿ���',120,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 213,N'�е���',121,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 214,N'�ػʵ���',122,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 215,N'�ȷ���',126,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 216,N'��ɽ��',128,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 217,N'������',130,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 218,N'������',131,82)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 219,N'������',89,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 220,N'����Ͽ��',188,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 221,N'֣����',189,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 222,N'������',192,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 223,N'�ܿ���',193,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 224,N'פ�����',197,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 225,N'������',198,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 226,N'������',207,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 227,N'������',228,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 228,N'ƽ��ɽ��',231,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 229,N'������',251,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 230,N'�ױ���',260,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 231,N'������',304,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 232,N'�����',305,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 233,N'�����',306,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 234,N'�����',307,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 235,N'������',308,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 236,N'��Դ��',309,189)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 237,N'������',65,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 238,N'������',66,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 239,N'ƽ����',67,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 240,N'ʯ����',68,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 241,N'������',71,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 242,N'��ͷ��',73,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 243,N'��ɽ��',74,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 244,N'������',255,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 245,N'������',256,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 246,N'������',257,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 247,N'����',261,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 248,N'������',262,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 249,N'������',263,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 250,N'������',266,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 251,N'��ˮ��',268,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 252,N'̨����',269,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 253,N'������',272,255)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 254,N'������',303,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 255,N'������',344,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 256,N'�Ͳ���',345,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 257,N'����',346,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 258,N'������',347,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 259,N'�Ĳ���',348,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 260,N'������',349,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 261,N'������',350,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 262,N'������',351,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 263,N'������',352,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 264,N'�ٸ���',353,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 265,N'��ɳ����������',354,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 266,N'�ֶ�����������',355,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 267,N'��ˮ����������',356,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 268,N'��ͤ��������������',357,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 269,N'������������������',358,303)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 270,N'�差��',196,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 271,N'������',202,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 272,N'�Ƹ���',203,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 273,N'��ʩ��',208,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 274,N'�人��',211,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 275,N'��ʯ��',310,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 276,N'������',314,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 277,N'Т����',315,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 278,N'������',316,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 279,N'������',317,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 280,N'������',318,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 281,N'������',319,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 282,N'Ǳ����',320,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 283,N'��ũ����',321,211)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 284,N'�żҽ���',214,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 285,N'������',215,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 286,N'������',217,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 287,N'��ɳ��',218,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 288,N'������',222,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 289,N'������',223,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 290,N'������',233,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 291,N'ɣֲ��',311,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 292,N'������',312,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 293,N'������',313,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 294,N'������',326,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 295,N'��̶��',327,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 296,N'������',328,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 297,N'¦����',329,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 298,N'������',387,218)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 299,N'��Ҵ��',49,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 300,N'�����',50,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 301,N'������',51,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 302,N'������',57,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 303,N'������',58,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 304,N'������',60,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 305,N'ƽ����',90,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 306,N'������',91,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 307,N'������',225,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 308,N'������',229,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 309,N'��ˮ��',377,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 310,N'��������',378,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 311,N'��Ȫ��',379,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 312,N'¤����',380,57)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 313,N'������',107,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 314,N'�ֳ���',271,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 315,N'��ƽ��',274,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 316,N'������',275,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 317,N'������',276,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 318,N'������',277,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 319,N'������',278,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 320,N'Ȫ����',279,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 321,N'������',286,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 322,N'������',287,276)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 323,N'��������',148,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 324,N'�տ������',149,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 325,N'������',150,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 326,N'ɽ�ϵ���',151,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 327,N'�������',152,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 328,N'��������',161,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 329,N'��֥����',169,150)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 330,N'�Ͻ���',219,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 331,N'������',220,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 332,N'ͭ����',221,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 333,N'��˳��',226,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 334,N'������',227,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 335,N'ǭ������',230,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 336,N'����ˮ��',368,227)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 337,N'��«����',25,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 338,N'�̽���',26,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 339,N'������',29,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 340,N'������',30,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 341,N'������',108,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 342,N'������',112,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 343,N'������',113,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 344,N'��ɽ��',114,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 345,N'������',115,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 346,N'��Ϫ��',116,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 347,N'��˳��',117,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 348,N'Ӫ����',123,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 349,N'������',124,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 350,N'�߷�����',129,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 351,N'������',133,115)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 352,N'������',79,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 353,N'�Ӱ���',87,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 354,N'������',186,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 355,N'μ����',187,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 356,N'������',190,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 357,N'������',191,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 358,N'������',194,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 359,N'ͭ����',374,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 360,N'������',375,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 361,N'������',376,186)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 362,N'������',48,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 363,N'������',55,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 364,N'������',56,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 365,N'������',155,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 366,N'������',157,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 367,N'������',158,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 368,N'������',195,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 369,N'������',210,56)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 370,N'���˰������',5,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 371,N'�ں���',6,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 372,N'���������',10,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 373,N'�绯��',11,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 374,N'�׸���',12,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 375,N'��ľ˹��',13,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 376,N'������',14,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 377,N'˫Ѽɽ��',15,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 378,N'��������',17,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 379,N'������',18,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 380,N'Į����',38,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 381,N'������',40,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 382,N'��̨����',42,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 383,N'ĵ������',97,17)
INSERT [tb_sys_city] ([CityID],[CityName],[CityCode],[DomainID]) VALUES ( 384,N'��Һ���',98,17)

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

INSERT [tb_sys_distribution] ([id],[userid],[receiveName],[postAddress],[province],[city],[telephone],[zipCode],[addtime],[cardNumber],[deliverytime],[ampm]) VALUES ( 51,1,N'����',N'�ķǹٷ���ʩ��������',N'�Ĵ�ʡ',N'�ɶ���',N'15151609119',N'165434',N'2012-10-19 10:09:19',N'19990003',N'2012-10-19 0:00:00',N'����')
INSERT [tb_sys_distribution] ([id],[userid],[receiveName],[postAddress],[province],[city],[telephone],[zipCode],[addtime],[cardNumber],[deliverytime],[ampm]) VALUES ( 52,1,N'��������',N'������������',N'�½�',N'������',N'15151609119',N'165456',N'2012-10-19 14:22:29',N'19990004',N'2012-10-20 0:00:00',N'����')
INSERT [tb_sys_distribution] ([id],[userid],[receiveName],[postAddress],[province],[city],[telephone],[zipCode],[addtime]) VALUES ( 54,1,N'dsafds',N'fdsafdsa',N'������',N'�����',N'16546546546',N'135465',N'2013-1-29 11:39:26')

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

INSERT [tb_sys_paramcenter] ([id],[name],[value],[typeTag],[addUserId],[addUserName],[addTime]) VALUES ( 16,N'ע�ά��',1,N'����',1,N'admin',N'2012-6-5 16:55:57')
INSERT [tb_sys_paramcenter] ([id],[name],[value],[typeTag],[addUserId],[addUserName],[addTime]) VALUES ( 17,N'��¼����',2,N'����',1,N'admin',N'2012-6-5 16:56:15')
INSERT [tb_sys_paramcenter] ([id],[name],[value],[typeTag],[addUserId],[addUserName],[addTime]) VALUES ( 18,N'������',3,N'����',1,N'admin',N'2012-6-5 16:56:24')
INSERT [tb_sys_paramcenter] ([id],[name],[value],[typeTag],[addUserId],[addUserName],[addTime]) VALUES ( 19,N'���ֶһ�',4,N'����',1,N'admin',N'2012-6-5 16:56:33')
INSERT [tb_sys_paramcenter] ([id],[name],[value],[typeTag],[addUserId],[addUserName],[addTime]) VALUES ( 20,N'�޸ļ���',5,N'����',1,N'admin',N'2012-6-5 18:07:36')
INSERT [tb_sys_paramcenter] ([id],[name],[value],[typeTag],[addUserId],[addUserName],[addTime]) VALUES ( 21,N'�޸�����',6,N'����',1,N'admin',N'2012-6-5 18:07:55')

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

INSERT [tb_sys_role] ([id],[roleName],[pageId],[addUser],[addTime]) VALUES ( 1,N'��������Ա',N'1,2,12,3,9,10,13,14,15,16,17,18,19,20,21,40,45,53,54,55,56,61,62,63,64,22,23,24,25,26,27,41,28,29,33,51,30,31,32,34,35,36,37,38,39,52,42,43,46,47,48,49,50,57,58,59,60,65,66,67,68,69,70',N'admin',N'2012-9-11 14:13:05')
INSERT [tb_sys_role] ([id],[roleName],[pageId],[addUser],[addTime]) VALUES ( 2,N'����༭',N'22,23,24,25,26,27,41',N'admin',N'2013-1-29 11:42:44')
INSERT [tb_sys_role] ([id],[roleName],[addUser],[addTime]) VALUES ( 3,N'���',N'admin',N'2012-5-23 12:55:19')

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

INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 1,1,N'�˵��б�',N'menu/Manage_Menu.aspx',1,1,N'2012-5-25 15:58:59',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 2,1,N'��Ӳ˵�',N'menu/Add_Menu.aspx',2,1,N'2012-5-30 10:31:24',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 3,2,N'ҳ���б�',N'syspage/Manage_Page.aspx',3,1,N'2012-5-25 16:04:46',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 9,2,N'����ļ�',N'syspage/Add_Page.aspx',2,1,N'2012-5-26 16:23:27',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 10,2,N'�޸��ļ�',N'syspage/Edit_Page.aspx',1,0,N'2012-5-26 16:17:50',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 12,1,N'�޸Ĳ˵�',N'menu/Edit_Menu.aspx',3,0,N'2012-5-25 16:00:20',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 13,3,N'��ɫ�б�',N'role/Manage_Role.aspx',1,1,N'2012-5-25 16:07:28',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 14,3,N'������ɫ',N'role/Add_Role.aspx',2,1,N'2012-5-25 16:07:22',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 15,3,N'��ɫ�޸�',N'role/Edit_Role.aspx',3,0,N'2012-5-25 16:07:49',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUser]) VALUES ( 16,4,N'ϵͳ�û��б�',N'sysuser/Manage_SysUser.aspx',1,1,N'2012-5-25 16:27:26',N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 17,4,N'����ϵͳ�û�',N'sysuser/Add_SysUser.aspx',0,1,N'2012-5-25 16:26:39',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 18,4,N'ϵͳ�û��޸�',N'sysuser/Edit_SysUser.aspx',3,0,N'2012-5-25 16:27:49',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 22,7,N'��ӻ�Ա',N'member/Add_Member.aspx',1,1,N'2012-5-26 16:29:00',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 23,7,N'��Ա��Ϣ�޸�',N'member/Edit_Member.aspx',0,0,N'2012-5-26 16:29:46',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 24,7,N'��Ա�б�',N'member/Manage_Member.aspx',1,1,N'2012-5-26 16:30:22',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 25,7,N'���͵�ַ����',N'member/Manage_Address.aspx',4,1,N'2012-5-26 16:33:23',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 26,7,N'�������͵�ַ',N'member/Add_Address.aspx',5,1,N'2012-5-26 16:36:14',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 27,7,N'�޸����͵�ַ',N'member/Edit_Address.aspx',6,0,N'2012-5-26 16:36:46',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 34,10,N'�����б�',N'sysparam/Manage_SysParam.aspx',1,1,N'2012-6-4 15:50:25',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 35,10,N'�������ò���',N'sysparam/Add_SysParam.aspx',2,1,N'2012-6-4 15:51:04',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 36,10,N'�����޸�',N'sysparam/Edit_SysParam.aspx',3,0,N'2012-6-4 15:52:17',1,N'admin')
INSERT [tb_sys_sysfiles] ([id],[classId],[fielsName],[filesUrl],[filesOrder],[showLeft],[addTime],[addUserId],[addUser]) VALUES ( 41,7,N'��Ա�����޸�',N'member/Edit_Psssword.aspx',7,0,N'2012-6-5 19:09:11',1,N'admin')

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

INSERT [tb_sys_sysmenu] ([id],[menuName],[menuOrder],[imgUrl],[addName],[addTime]) VALUES ( 1,N'�˵�����',3,N'../Images/Ico/menu.gif',N'admin',N'2012-5-26 16:43:37')
INSERT [tb_sys_sysmenu] ([id],[menuName],[menuOrder],[imgUrl],[addName],[addTime]) VALUES ( 2,N'ҳ�����',2,N'../Images/Ico/pageChild.gif',N'admin',N'2012-5-26 17:06:03')
INSERT [tb_sys_sysmenu] ([id],[menuName],[menuOrder],[imgUrl],[addName],[addTime]) VALUES ( 3,N'��ɫ����',4,N'../Images/Ico/anonymous.gif',N'admin',N'2012-5-26 16:43:40')
INSERT [tb_sys_sysmenu] ([id],[menuName],[menuOrder],[imgUrl],[addName],[addTime]) VALUES ( 4,N'ϵͳ�û�',5,N'../Images/Ico/administrat.gif',N'admin',N'2012-5-26 17:05:06')
INSERT [tb_sys_sysmenu] ([id],[menuName],[menuOrder],[imgUrl],[addName],[addTime]) VALUES ( 7,N'��Ա����',1,N'../Images/Ico/memberuser.gif',N'admin',N'2013-1-29 11:41:27')
INSERT [tb_sys_sysmenu] ([id],[menuName],[menuOrder],[imgUrl],[addName],[addTime]) VALUES ( 10,N'ϵͳ����',6,N'../Images/Ico/paramset.gif',N'admin',N'2012-6-4 15:48:38')

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

INSERT [tb_sys_userinfo] ([ID],[userName],[password],[trueName],[currentScore],[totalScore],[sex],[province],[city],[isBusiness],[phone],[address],[addTime]) VALUES ( 12,N'�������',N'8c581610fac95907f78680a2422c111b',N'������',30,30,1,N'�㽭ʡ',N'������',0,N'15151609119',N'������������·�ɻ�Է',N'2013-1-24 14:38:13')

SET IDENTITY_INSERT [tb_sys_userinfo] OFF
