USE [StudentManager]
GO
CREATE PROCEDURE usp_changepassword
(
	@UserName NVARCHAR(50)
	,@Password NVARCHAR(50)
)
AS
	BEGIN
UPDATE [dbo].[Users]
   SET 
      [Password] = @Password
 WHERE [UserName]=@UserName
	END 
GO


