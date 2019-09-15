-- =============================================
-- Author:		Jimmy Sietsma
-- Create date: 04/22/2019
-- Description:	Add a new plant type to the plant dictionary
-- =============================================
CREATE PROCEDURE Add_PlantType 
	
	@PlantName NVARCHAR(100),
	@LightingLevel INT,
	@NeedsFertilizer BIT,
	@CanFloat BIT,
	@MinTemperature INT,
	@MaxTemperature INT,
	@IdealTemperature INT,
	@MaxHeight FLOAT,
	@PlantSizeClass INT,
	@PurchaseCategory INT,
	@PlantImage NVARCHAR(max)

AS
BEGIN	
	SET NOCOUNT ON;
    
	INSERT INTO dbo.LivePlantTypes
	(
	    PlantName,
	    fk_LightingLevel,
	    NeedsFertilizer,
	    CanFloat,
	    PlantMinTemp,
	    PlantMaxTemp,
	    PlantIdealTemp,
	    PlantMaxHeight,
	    fk_PlantSizeClass,
	    fk_PurchaseCategory,
	    PlantImage
	)
	VALUES
	(   @PlantName,  -- PlantName - nvarchar(50)
	    @LightingLevel,    -- fk_LightingLevel - int
	    @NeedsFertilizer, -- NeedsFertilizer - bit
	    @CanFloat, -- CanFloat - bit
	    @MinTemperature,    -- PlantMinTemp - int
	    @MaxTemperature,    -- PlantMaxTemp - int
	    @IdealTemperature,    -- PlantIdealTemp - int
	    @MaxHeight,  -- PlantMaxHeight - float
	    @PlantSizeClass,    -- fk_PlantSizeClass - int
	    @PurchaseCategory,    -- fk_PurchaseCategory - int
	    @PlantImage   -- PlantImage - nvarchar(max)
	    )
END
