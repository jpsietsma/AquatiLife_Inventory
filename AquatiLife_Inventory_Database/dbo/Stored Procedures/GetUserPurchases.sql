
-- =============================================
-- Author:		Jimmy Sietsma
-- Create date: 05/07/2019
-- Description:	Get a list of user purchases by category
-- =============================================
CREATE PROCEDURE [dbo].[GetUserPurchases] 
	@UserID INT, 
	@PurchaseCategory INT
AS
BEGIN
	SET NOCOUNT ON;

	SET @PurchaseCategory = (SELECT ISNULL(@PurchaseCategory, '0'))

	IF @PurchaseCategory = 0
		BEGIN
			SELECT * FROM dbo.UserPurchases WHERE fk_UserID = @UserID
		END
	ELSE
		BEGIN
			SELECT * FROM dbo.UserPurchases WHERE fk_UserID = @UserID AND fk_PurchaseCategory = @PurchaseCategory
		END
END
