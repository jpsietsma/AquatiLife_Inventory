CREATE VIEW dbo.vw_MasterFishDictionary
AS
SELECT        fishTypes.pk_FishTypeID, animalTypes.AnimalTypeName AS AnimalType, fishTypes.TypeName AS FishType, familyTypes.FishFamilyName AS FishFamily, fishTypes.TankPopulationEncumbrance AS TankEncumbrance, 
                         fishTypes.FishTypeImagePath, feedingTypes.FeedingType, birthingTypes.BirthingType, fishTypes.FishMinTankSize AS MinGallons, agressionLevels.AgressionLevel AS Agressiveness, territoryLevels.TerritorialLevel, 
                         waterTypes.WaterTypeName, careGuides.DocumentPath AS CareGuideDocumentPath
FROM            dbo.FishTypes AS fishTypes INNER JOIN
                         dbo.List_FishFamilyTypes AS familyTypes ON fishTypes.fk_FishFamily = familyTypes.pk_FamilyID INNER JOIN
                         dbo.List_FishFeedingTypes AS feedingTypes ON fishTypes.fk_FishFeederType = feedingTypes.pk_FeedingTypeID INNER JOIN
                         dbo.List_FishBirthingTypes AS birthingTypes ON fishTypes.fk_BirthingType = birthingTypes.pk_BirthTypeID INNER JOIN
                         dbo.List_FishAgressionLevels AS agressionLevels ON fishTypes.fk_FishAgressionLevel = agressionLevels.pk_AgressionLevelID INNER JOIN
                         dbo.List_FishTerritorialLevels AS territoryLevels ON fishTypes.fk_FishTerritorialLevel = territoryLevels.pk_TerritorialLevelID INNER JOIN
                         dbo.List_WaterTypes AS waterTypes ON fishTypes.fk_WaterType = waterTypes.pk_WaterTypeID INNER JOIN
                         dbo.List_AnimalTypes AS animalTypes ON familyTypes.fk_AnimalType = animalTypes.pk_AnimalTypeID LEFT OUTER JOIN
                         dbo.FishCareGuides AS careGuides ON fishTypes.fk_CareGuideID = careGuides.pk_CareGuideID

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[52] 4[9] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "fishTypes"
            Begin Extent = 
               Top = 47
               Left = 3
               Bottom = 312
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "familyTypes"
            Begin Extent = 
               Top = 1
               Left = 278
               Bottom = 131
               Right = 455
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "careGuides"
            Begin Extent = 
               Top = 335
               Left = 278
               Bottom = 465
               Right = 451
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "animalTypes"
            Begin Extent = 
               Top = 0
               Left = 484
               Bottom = 113
               Right = 675
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "waterTypes"
            Begin Extent = 
               Top = 339
               Left = 774
               Bottom = 452
               Right = 980
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "territoryLevels"
            Begin Extent = 
               Top = 266
               Left = 995
               Bottom = 362
               Right = 1190
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "agressionLevels"
            Begin Extent = 
               Top = 164
               Left = 996
               Bottom = 260
               Right = 1193
            End', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_MasterFishDictionary';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "birthingTypes"
            Begin Extent = 
               Top = 102
               Left = 813
               Bottom = 215
               Right = 983
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "feedingTypes"
            Begin Extent = 
               Top = 11
               Left = 989
               Bottom = 107
               Right = 1174
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 17
         Width = 284
         Width = 1380
         Width = 1710
         Width = 1680
         Width = 2505
         Width = 1500
         Width = 1815
         Width = 1245
         Width = 1275
         Width = 1200
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1650
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_MasterFishDictionary';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_MasterFishDictionary';

