-- =============================================
-- Author:		Jimmy Sietsma
-- Create date:04/09/2019
-- Description:	Insert new user tank records into the database
-- =============================================
CREATE PROCEDURE dbo.Add_UserTank 

	@TankOwnerID INT,
	@TankSize INT,
	@TankHeight DECIMAL,
	@TankWidth DECIMAL,
	@WaterType INT,
	@TankType INT

AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO dbo.UserTanks (fk_TankOwner, TankSize, TankHeight, TankWidth, fk_TankWaterType, fk_TankType) VALUES (@TankOwnerID, @TankSize, @TankHeight, @TankWidth, @WaterType, @TankType)

END
