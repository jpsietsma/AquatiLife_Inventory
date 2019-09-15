-- =============================================
-- Author:		Jimmy Sietsma
-- Create date: 04/21/2019
-- Last Updated: 06/09/2019
-- Description:	Add a new purchase to the database, 
--              if purchase is live, add a record to the 
--              userfishinventory and UserFish tables as well
-- =============================================
CREATE PROCEDURE [dbo].[Add_UserPurchase] 
	-- Add the parameters for the stored procedure here	
	@Quantity INT, 
	@Cost DECIMAL(4,2),
	@Date DATETIME,
	@StoreID INT,
	@PurchaseCategory INT,
	@UserID INT,
	@Description NVARCHAR(255) = NULL,
	@UserTank INT = NULL,
	@FishType INT = NULL,
	@LivePlantType INT = NULL
AS
BEGIN
	SET NOCOUNT ON;

	--Set description to '~<PurchaseTypeDescription>' if null
	SET @Description = ISNULL(@Description, CONCAT('~', (SELECT TOP(1) PurchaseTypeDescription FROM dbo.List_PurchaseCategories WHERE pk_PurchaseTypeID = @PurchaseCategory ORDER BY pk_PurchaseTypeID)))

	--Create a record for the purchase in UserPurchases
    INSERT INTO dbo.UserPurchases
    (
        Date,
        Quantity,
        fk_StoreID,
        fk_PurchaseCategory,
        Cost,
        fk_UserID,
        Description
    )
    VALUES
    (   @Date, -- Date - nvarchar(50)
        @Quantity,   -- Quantity - int
        @StoreID,   -- fk_StoreID - int
        @PurchaseCategory,   -- fk_PurchaseCategory - int
        @Cost, -- Cost - decimal(2,0)
        @UserID,   -- fk_UserID - int
        @Description  -- Description - nvarchar(255)
    )

	--Save the recently created purchase primary key
	DECLARE @RecentPurchaseAdded INT = SCOPE_IDENTITY();	

	--If the quantity is greater than 0 and its a live animal purchase
	IF @Quantity > 0
	BEGIN
		DECLARE @i INT = 1;
		WHILE @i <= @Quantity
		BEGIN
			IF @PurchaseCategory IN (1,6)
			BEGIN
			--If user didnt select a fish type and the purchase was a live fish, set to unknown type
			SET @FishType = ISNULL(@FishType, 23)

			--Insert a record into UserFish for each fish purchased
				INSERT INTO dbo.UserFish
				(
					IsAlive,
					FishNotes,
					SizeLength,
					FriendlyName,
					Color
				)
				VALUES
				(   N'1', -- IsAlive - nvarchar(50)
					(SELECT TOP(1) TypeName FROM dbo.FishTypes WHERE pk_FishTypeID = @FishType ORDER BY pk_FishTypeID),  -- FishNotes - text
					0.0, -- SizeLength - float
					NULL, -- FriendlyName - nvarchar(100)
					NULL  -- Color - nvarchar(100)
				)
	
				DECLARE @RecentUserFish INT = SCOPE_IDENTITY();

				--If user does not specify the tank the fish belongs in, set to unassigned
				SET @UserTank = ISNULL(@UserTank, 10)

				--Insert a record into the UserFishInventory table for each fish purchased
				INSERT INTO dbo.UserFishInventory
				(
					fk_UserID,
					fk_UserFishID,
					fk_UserPurchaseID,
					fk_FishType,
					fk_UserTank
				)
				VALUES
				(   @UserID, -- fk_UserID - int
					@RecentUserFish, -- fk_UserFishID - int
					@RecentPurchaseAdded, -- fk_UserPurchaseID - int
					@FishType, -- fk_FishType - int
					@UserTank  -- fk_UserTank - int
				)
			END
			--If the purchase was a new tank			
			ELSE IF @PurchaseCategory = 8
			BEGIN
				INSERT INTO dbo.UserTanks
				(
				    fk_TankOwner,
				    TankSize,
				    TankHeight,
				    TankWidth,
				    fk_TankWaterType,
				    fk_TankType,
				    TankDisplayName,
				    IsActiveTank
				)
				VALUES
				(   @UserID,   -- fk_TankOwner - int
				    0,   -- TankSize - int
				    N'0', -- TankHeight - nvarchar(10)
				    N'0', -- TankWidth - nvarchar(10)
				    0,   -- fk_TankWaterType - int
				    0,   -- fk_TankType - int
				    N'New Tank needs configuration', -- TankDisplayName - nvarchar(200)
				    0 -- IsActiveTank - bit
				    )
			END
			--If the purchase was a new live plant
			ELSE IF @PurchaseCategory = 2
			BEGIN
				INSERT INTO dbo.UserLivePlants
				(
				    fk_UserID,
				    fk_TankID,
				    fk_PurchaseID,
				    fk_PlantType
				)
				VALUES
				(   @UserID, -- fk_UserID - int
				    @UserTank, -- fk_TankID - int
				    @RecentPurchaseAdded, -- fk_PurchaseID - int
				    ISNULL(@LivePlantType, 10)  -- fk_PlantType - int
				    )
			END
			--Any other purchases that don't fall into one of the aforementioned categories
			ELSE
			BEGIN
				INSERT INTO dbo.UserTankSupplyInventory
				(
				    QuantityOnHand,
				    fk_PurchaseID,
				    fk_UserID,
				    fk_UserTankID,
				    ExpirationDays
				)
				VALUES
				(   @Quantity, -- QuantityOnHand - int
				    @RecentPurchaseAdded, -- fk_PurchaseID - int
				    @UserID, -- fk_UserID - int
				    @UserTank, -- fk_UserTankID - int
				    30  -- ExpirationDays - int
				    )
			END

			SET @i = @i + 1;
		END
	END
END
