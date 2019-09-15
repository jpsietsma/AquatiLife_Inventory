-- =============================================
-- Author:		<Jimmy Sietsma>
-- Create date: <2019-06-10>
-- Description:	<Record a live animal as deceased>
-- =============================================
CREATE PROCEDURE [dbo].[RecordFishDeath] 
	@FishID INT,
	@TimeOfDeath DATETIME,
	@Description TEXT,
	@Classification INT,
	@SubClassification INT
AS
BEGIN

SET NOCOUNT ON;

	--If a record for the passed in FishID exists
    IF EXISTS(SELECT pk_FishID FROM dbo.UserFishInventory WHERE pk_FishID = @FishID)
	BEGIN
		--Insert a record into the UserFishMedicalRecords table indication the fish has died, linked by the passed FishID
		INSERT INTO dbo.UserFishMedicalRecords
		(
		    RecordDate,
		    fk_FishID,
		    Description,
		    fk_MedicalClassification,
			fk_MedicalSubClassification
		)
		VALUES
		(   
			@TimeOfDeath,				-- RecordDate - datetime
		    @FishID,				-- fk_FishID - int
		    @Description,			-- Description - text
		    @Classification,		-- fk_MedicalClassification - int
			@SubClassification 		-- fk_MedicalClassification - int
		)

		--Update the UserFish table to indicate fish is no longer alive, and set a note indicating also, where clause using the results of searching for the fk_UserFishID in the matching FishID record in UserFishInventory
		UPDATE dbo.UserFish SET IsAlive = 0, FishNotes = CONCAT('[Deceased] ', FishNotes) WHERE pk_UserFishID = @FishID	

		--If the fish death classification is from death, sickness, or other and subclass is from sickness or injury non-fighting
		IF @Classification IN (3,4,5) AND @SubClassification IN (1,2,3,5,6,7)
		BEGIN

		--Set the tank test description to 'Pending test due to fish death - <fishType> - <FishFriendlyName>: [TOD] <DateOfDeath>'
		DECLARE @TextDescription NVARCHAR(max) = CONCAT('Pending tank test in response to fish death - ', (SELECT TypeName FROM dbo.FishTypes WHERE pk_FishTypeID = (SELECT fk_FishType  FROM dbo.UserFishInventory WHERE fk_UserFishID = @FishID)), ' - ', (SELECT FriendlyName FROM dbo.UserFish WHERE pk_UserFishID = @FishID), ': [TOD] ' + CONVERT(NVARCHAR(max),@TimeOfDeath))
		DECLARE @PreviousTank INT = (SELECT TOP(1) fk_UserTank FROM dbo.UserFishInventory WHERE pk_FishID = @FishID ORDER BY fk_UserTank)
		
			--Insert a record into the UserTankTests table to indicate a water test that must be performed
			--This tank test should eventually ultimately determine if a death was from negligence.  If all tests pass, then original conclusion is kept
			--If any test fails, then we must assume that the death was from negligence unless it can be disproven.
			INSERT INTO dbo.UserTankTests
			(
				TestDate,
				fk_UserTank,
				fk_TestType,
				NitriteLevel,
				NitrateLevel,
				gHLevel,
				cHLevel,
				pHLevel,
				ActionsTaken
			)
			VALUES
			(   NULL,					 -- TestDate - datetime
				@PreviousTank,         -- fk_UserTank - int
				4,						 -- fk_TestType - int
				0.0,					 -- NitriteLevel - float
				0.0,					 -- NitrateLevel - float
				0.0,					 -- gHLevel - float
				0.0,					 -- cHLevel - float
				0.0,					 -- pHLevel - float
				@TextDescription         -- ActionsTaken - text
			)

		END

		--Update the UserFishInventory table and set the foreign key to the tank for the deceased fish to the unassigned tank.
		UPDATE dbo.UserFishInventory SET fk_UserTank = 10 WHERE fk_UserFishID = @FishID

	END

END
