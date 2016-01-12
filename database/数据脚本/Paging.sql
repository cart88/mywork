USE [TestDB]
GO
/****** Object:  StoredProcedure [dbo].[Paging]    Script Date: 01/29/2013 16:54:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE  [dbo].[Paging] 
@sql nvarchar(4000),--要执行的sql语句
@page int=1, --要显示的页码
@pageSize int,--每页的大小
@pageCount int=0 out,--总页数
@recordCount int=0 out,--总记录数
@SearchTime int=0 out
as
declare @usetime datetime
set @usetime=getdate()
set nocount on
begin
declare @p1 int
exec sp_cursoropen @p1 output,@sql,@scrollopt=1,@ccopt=1,@rowcount=@pagecount output
set @recordCount = @pageCount
select @pagecount=ceiling(1.0*@pagecount/@pagesize)
,@page=(@page-1)*@pagesize+1
exec sp_cursorfetch @p1,16,@page,@pagesize 
exec sp_cursorclose @p1
set  @SearchTime=datediff(ms,@usetime,getdate())
print @SearchTime
end