USE [TestDB]
GO
/****** Object:  StoredProcedure [dbo].[PageList]    Script Date: 01/29/2013 16:54:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE  [dbo].[PageList]
    (
        @tblName VARCHAR(255), -- ����
        @strGetFields VARCHAR(1000) = '*', -- ��Ҫ���ص���
        @fldName VARCHAR(255)='', -- ������ֶ���
        @PageSize INT = 10, -- ҳ�ߴ�
        @PageIndex INT = 1, -- ҳ��
        @doCount BIT = 0, -- ���ؼ�¼����, �� 0 ֵ�򷵻�
        @OrderType INT = 0, -- ������������, �� 0 ֵ����
        @strWhere VARCHAR(1500) = '' -- ��ѯ���� (ע��: ��Ҫ�� WHERE)
    )
AS

    SET NOCOUNT ON

        DECLARE @strSQL VARCHAR(5000) -- �����
        --DECLARE @strTmp VARCHAR(110) -- ��ʱ����
        DECLARE @strOrder VARCHAR(400) -- ��������
       
        IF(@doCount != 0)
            BEGIN
                IF @strWhere !=''
                    SET @strSQL = 'SELECT COUNT(1) AS Total FROM [' + @tblName + '] WHERE '+@strWhere
                ELSE
                    SET @strSQL = 'SELECT COUNT(1) AS Total FROM [' + @tblName + ']'
            END
            --���ϴ������˼�����@doCount���ݹ����Ĳ���0����ִ������ͳ�ơ����µ����д��붼��@doCountΪ0�����
        ELSE
            BEGIN
				IF @fldName !=''
					BEGIN
						IF @OrderType = 0
							BEGIN                       
								SET @strOrder = ' ORDER BY [' + @fldName +'] ASC'
								--���@OrderType ��1����ִ�н���������Ҫ
							END
						ELSE If @OrderType = 1
							BEGIN
								SET @strOrder = ' ORDER BY [' + @fldName +'] DESC'
							END
						ELSE --���@OrderType ���������Ͳ�������Ӻ�׺������Ĭ��
							BEGIN
								SET @strOrder = ' ORDER BY ' + @fldName +' '
							END
					END
                
                 IF @strWhere != ''
                    SET @strSQL = 'SELECT '+@strGetFields+ ' FROM [' + @tblName + '] WHERE ' + @strWhere + ' ' + @strOrder
                 ELSE
                    SET @strSQL = 'SELECT '+@strGetFields+ ' FROM ['+ @tblName + '] '+ @strOrder
                        --����ǵ�һҳ��ִ�����ϴ��룬������ӿ�ִ���ٶ�
				
				
            END

		declare @pageCount int --��ҳ��
		declare @recordCount int --�ܼ�¼��
		declare @SearchTime int   --ִ��ʱ��

		EXEC Paging @strSQL,@PageIndex,@PageSize,@pageCount output,@recordCount output,@SearchTime output
		select @pageCount as 'pageCount',@recordCount as 'recordCount',@SearchTime as 'SearchTime'
		select @strSQL 
	SET NOCOUNT OFF
