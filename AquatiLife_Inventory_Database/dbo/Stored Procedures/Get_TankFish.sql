
-- =============================================
-- Author:		Jimmy Sietsma
-- Create date: 5/25/2019
-- Description:	Get Fish associated with tank by pk_TankID
-- =============================================
CREATE PROCEDURE [dbo].[Get_TankFish] 
	@TankID INT
AS
BEGIN
	
	SELECT * FROM UserFishInventory WHERE fk_UserTank = @TankID

END
