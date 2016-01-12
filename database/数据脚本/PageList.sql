USE [TestDB]
GO
/****** Object:  StoredProcedure [dbo].[PageList]    Script Date: 01/29/2013 16:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE  [dbo].[PageList]
    (
        @tblName VARCHAR(255), -- 表名
        @strGetFields VARCHAR(1000) = '*', -- 需要返回的列
        @fldName VARCHAR(255)='', -- 排序的字段名
        @PageSize INT = 10, -- 页尺寸
        @PageIndex INT = 1, -- 页码
        @doCount BIT = 0, -- 返回记录总数, 非 0 值则返回
        @OrderType INT = 0, -- 设置排序类型, 非 0 值则降序
        @strWhere VARCHAR(1500) = '' -- 查询条件 (注意: 不要加 WHERE)
    )
AS

    SET NOCOUNT ON

        DECLARE @strSQL VARCHAR(5000) -- 主语句
        --DECLARE @strTmp VARCHAR(110) -- 临时变量
        DECLARE @strOrder VARCHAR(400) -- 排序类型
       
        IF(@doCount != 0)
            BEGIN
                IF @strWhere !=''
                    SET @strSQL = 'SELECT COUNT(1) AS Total FROM [' + @tblName + '] WHERE '+@strWhere
                ELSE
                    SET @strSQL = 'SELECT COUNT(1) AS Total FROM [' + @tblName + ']'
            END
            --以上代码的意思是如果@doCount传递过来的不是0，就执行总数统计。以下的所有代码都是@doCount为0的情况
        ELSE
            BEGIN
				IF @fldName !=''
					BEGIN
						IF @OrderType = 0
							BEGIN                       
								SET @strOrder = ' ORDER BY [' + @fldName +'] ASC'
								--如果@OrderType 是1，就执行降序，这句很重要
							END
						ELSE If @OrderType = 1
							BEGIN
								SET @strOrder = ' ORDER BY [' + @fldName +'] DESC'
							END
						ELSE --如果@OrderType 是其他，就不额外添加后缀，采用默认
							BEGIN
								SET @strOrder = ' ORDER BY ' + @fldName +' '
							END
					END
                
                 IF @strWhere != ''
                    SET @strSQL = 'SELECT '+@strGetFields+ ' FROM [' + @tblName + '] WHERE ' + @strWhere + ' ' + @strOrder
                 ELSE
                    SET @strSQL = 'SELECT '+@strGetFields+ ' FROM ['+ @tblName + '] '+ @strOrder
                        --如果是第一页就执行以上代码，这样会加快执行速度
				
				
            END

		declare @pageCount int --总页数
		declare @recordCount int --总记录数
		declare @SearchTime int   --执行时间

		EXEC Paging @strSQL,@PageIndex,@PageSize,@pageCount output,@recordCount output,@SearchTime output
		select @pageCount as 'pageCount',@recordCount as 'recordCount',@SearchTime as 'SearchTime'
		select @strSQL 
	SET NOCOUNT OFF
