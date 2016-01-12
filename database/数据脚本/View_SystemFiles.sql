SELECT     dbo.tb_sys_sysfiles.id, dbo.tb_sys_sysfiles.classId, dbo.tb_sys_sysfiles.fielsName, dbo.tb_sys_sysfiles.filesUrl, dbo.tb_sys_sysfiles.showLeft, 
                      dbo.tb_sys_sysfiles.addUser, dbo.tb_sys_sysfiles.addTime, dbo.tb_sys_sysmenu.menuName
FROM         dbo.tb_sys_sysfiles LEFT OUTER JOIN
                      dbo.tb_sys_sysmenu ON dbo.tb_sys_sysmenu.id = dbo.tb_sys_sysfiles.classId