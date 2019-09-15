CREATE VIEW dbo.[vw_FishDictionary]
AS
SELECT        fishtypes.pk_FishTypeID AS [Fish ID], fishtypes.TypeName AS [Fish Type], fishtypes.FishTypeImagePath AS FishImageFilepath, fishtypes.FishMinTankSize AS [Minimum Tank (gallons)], 
                         watertypes.WaterTypeName AS [Water Type], watertypes.WaterTypeSpecialTags AS [Water Notes], birthingtypes.BirthingType AS [Birthing Type], birthingtypes.SpecialNotes AS [Birthing Notes], 
                         feedingtypes.FeedingType AS [Feeding Type], careguides.DocumentPath AS [Care Guide Filepath], agressiveness.AgressionLevel AS [Mentality Agression], familytypes.FishFamilyName AS [Fish Family], 
                         territorialLevel.TerritorialLevel AS [Mentality Territorial]
FROM            dbo.FishTypes AS fishtypes LEFT OUTER JOIN
                         dbo.List_WaterTypes AS watertypes ON fishtypes.fk_WaterType = watertypes.pk_WaterTypeID LEFT OUTER JOIN
                         dbo.List_FishBirthingTypes AS birthingtypes ON fishtypes.fk_BirthingType = birthingtypes.pk_BirthTypeID LEFT OUTER JOIN
                         dbo.List_FishFeedingTypes AS feedingtypes ON fishtypes.fk_FishFeederType = feedingtypes.pk_FeedingTypeID LEFT OUTER JOIN
                         dbo.FishCareGuides AS careguides ON fishtypes.fk_CareGuideID = careguides.pk_CareGuideID LEFT OUTER JOIN
                         dbo.List_FishAgressionLevels AS agressiveness ON fishtypes.fk_FishAgressionLevel = agressiveness.pk_AgressionLevelID LEFT OUTER JOIN
                         dbo.List_FishFamilyTypes AS familytypes ON fishtypes.fk_FishFamily = familytypes.pk_FamilyID LEFT OUTER JOIN
                         dbo.List_FishTerritorialLevels AS territorialLevel ON fishtypes.fk_FishTerritorialLevel = territorialLevel.pk_TerritorialLevelID

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[56] 4[13] 2[17] 3) )"
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
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "fishtypes"
            Begin Extent = 
               Top = 211
               Left = 17
               Bottom = 540
               Right = 210
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "watertypes"
            Begin Extent = 
               Top = 483
               Left = 293
               Bottom = 545
               Right = 501
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "birthingtypes"
            Begin Extent = 
               Top = 175
               Left = 340
               Bottom = 288
               Right = 510
            End
            DisplayFlags = 344
            TopColumn = 0
         End
         Begin Table = "feedingtypes"
            Begin Extent = 
               Top = 121
               Left = 285
               Bottom = 183
               Right = 471
            End
            DisplayFlags = 344
            TopColumn = 0
         End
         Begin Table = "careguides"
            Begin Extent = 
               Top = 562
               Left = 239
               Bottom = 624
               Right = 412
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "agressiveness"
            Begin Extent = 
               Top = 235
               Left = 366
               Bottom = 297
               Right = 563
            End
            DisplayFlags = 344
            TopColumn = 0
         End
         Begin Table = "familytypes"
            Begin Extent = 
               Top = 68
               Left = 244
               Bottom = 130
               Right = 421
            ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_FishDictionary';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'End
            DisplayFlags = 344
            TopColumn = 0
         End
         Begin Table = "territorialLevel"
            Begin Extent = 
               Top = 291
               Left = 393
               Bottom = 387
               Right = 589
            End
            DisplayFlags = 344
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 31
         Width = 284
         Width = 1500
         Width = 1845
         Width = 1500
         Width = 2055
         Width = 1800
         Width = 1845
         Width = 1545
         Width = 1500
         Width = 1800
         Width = 1845
         Width = 2085
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
      Begin ColumnWidths = 11
         Column = 2085
         Alias = 2835
         Table = 1635
         Output = 1740
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_FishDictionary';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_FishDictionary';

