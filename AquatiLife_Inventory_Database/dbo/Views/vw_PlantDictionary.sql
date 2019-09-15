CREATE VIEW dbo.vw_PlantDictionary
AS
SELECT        plantTypes.pk_PlantID AS TypeID, plantTypes.PlantName AS PlantType, plantTypes.NeedsFertilizer AS Fertilizer, plantTypes.CanFloat AS Floatable, plantTypes.PlantMinTemp AS MinTemp, 
                         plantTypes.PlantMaxTemp AS MaxTemp, plantTypes.PlantIdealTemp AS IdealTemp, plantTypes.PlantMaxHeight AS MaxInches, ISNULL(plantTypes.PlantImage, '-image unavailable-') AS Image, 
                         pc.PurchaseTypeDescription AS ItemType, lightingLevels.LightingLevelName AS Lighting, sizeClasses.PlantSizeClassName AS PlantSize
FROM            dbo.LivePlantTypes AS plantTypes LEFT OUTER JOIN
                         dbo.List_PurchaseCategories AS pc ON plantTypes.fk_PurchaseCategory = pc.pk_PurchaseTypeID LEFT OUTER JOIN
                         dbo.List_TankLightingLevels AS lightingLevels ON plantTypes.fk_LightingLevel = lightingLevels.pk_LightingLevelID LEFT OUTER JOIN
                         dbo.List_PlantSizeClasses AS sizeClasses ON plantTypes.fk_PlantSizeClass = sizeClasses.pk_SizeClassID

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "pc"
            Begin Extent = 
               Top = 196
               Left = 301
               Bottom = 292
               Right = 524
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "lightingLevels"
            Begin Extent = 
               Top = 6
               Left = 537
               Bottom = 102
               Right = 729
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "plantTypes"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 238
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "sizeClasses"
            Begin Extent = 
               Top = 135
               Left = 740
               Bottom = 231
               Right = 935
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
      Begin ColumnWidths = 23
         Width = 284
         Width = 825
         Width = 1425
         Width = 960
         Width = 1020
         Width = 1080
         Width = 1110
         Width = 1110
         Width = 1275
         Width = 1845
         Width = 1080
         Width = 1755
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin Colum', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_PlantDictionary';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'nWidths = 11
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_PlantDictionary';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_PlantDictionary';

