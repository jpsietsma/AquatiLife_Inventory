-- =============================================
-- Author:		Jimmy Sietsma
-- Create date: 04/11/2019 
-- Description:	Add a new user plant to the UserPlants table
-- =============================================
CREATE PROCEDURE Add_UserPlant 

	@UserID INT,
	@TankID INT, 
	@PurchaseID INT,
	@PlantType INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO dbo.UserLivePlants
    (
        fk_UserID,
        fk_TankID,
        fk_PurchaseID,
        fk_PlantType
    )
    VALUES
    (   @UserID, -- fk_UserID - int
        @TankID, -- fk_TankID - int
        @PurchaseID, -- fk_PurchaseID - int
        @PlantType  -- fk_PlantType - int
        )
END
