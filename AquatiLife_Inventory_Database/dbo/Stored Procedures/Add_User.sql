-- =============================================
-- Author:		Jimmy Sietsma
-- Create date:04/09/2019
-- Description:	Insert new user tank records into the database
-- =============================================
CREATE PROCEDURE dbo.Add_User 

	@UserName NVARCHAR(50),
	@Password NVARCHAR(50),
	@EmailAddress NVARCHAR(100),
	@UserRole NVARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO dbo.Users (UserName, Password, EmailAddress, UserRole) VALUES (@UserName, @Password, @EmailAddress, @UserRole)

END
