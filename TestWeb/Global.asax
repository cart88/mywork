﻿<%@ Application Language="C#" %>

<script RunAt="server">

    void Application_Start(object sender, EventArgs e)
    {
        //在应用程序启动时运行的代码

        /*
        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(this.Server.MapPath("~/App_Data/ViewState/"));
        if (!dir.Exists)
            dir.Create();
        else
        {
            DateTime nt = DateTime.Now.AddMinutes(-5);//标记时间为5分钟，5分钟之前生成的文件将全部被删除掉
            foreach (System.IO.FileInfo f in dir.GetFiles())
            {
                if (f.CreationTime < nt)
                    f.Delete();
            }
        }
         */
    }

    void Application_End(object sender, EventArgs e)
    {
        //在应用程序关闭时运行的代码

    }

    void Application_Error(object sender, EventArgs e)
    {
        //在出现未处理的错误时运行的代码

    }

    void Session_Start(object sender, EventArgs e)
    {
        //在新会话启动时运行的代码

    }

    void Session_End(object sender, EventArgs e)
    {
        //在会话结束时运行的代码。 
        // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为
        // InProc 时，才会引发 Session_End 事件。如果会话模式 
        //设置为 StateServer 或 SQLServer，则不会引发该事件。

    }
       
</script>

