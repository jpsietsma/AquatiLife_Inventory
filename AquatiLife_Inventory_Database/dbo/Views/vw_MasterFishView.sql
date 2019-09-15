CREATE VIEW dbo.vw_MasterFishView
AS
SELECT        UF.IsAlive, UF.FishNotes, UF.SizeLength, UF.FriendlyName, UF.LastTankMove, COLORS.ColorName, COLORS2.ColorName AS SecondaryColor, USERS.UserName, FISHTYPES.TypeName, 
                         FISHTYPES.TankPopulationEncumbrance, FISHTYPES.FishTypeImagePath, FISHTYPES.FishMinTankSize, PURCHASES.Date AS PurchaseDate, PURCHASES.Cost AS PurchaseCost, PURCHASES.Description, 
                         FISHTANKS.TankDisplayName, FISHTANKS.TankSize, WATERTYPES.WaterTypeName, STORES.StoreName, TERRITORY.TerritorialLevel, AGRESSIVENESS.AgressionLevel, FEEDTYPE.FeedingType, BIRTH.BirthingType, 
                         UFI.pk_FishID AS fk_UFI, UF.pk_UserFishID AS fk_UserFish, PURCHASES.pk_PurchaseID AS fk_UserPurchase
FROM            dbo.UserFish AS UF INNER JOIN
                         dbo.UserFishInventory AS UFI ON UF.pk_UserFishID = UFI.pk_FishID INNER JOIN
                         dbo.List_FishColors AS COLORS ON UF.fk_fishColor = COLORS.pk_colorID INNER JOIN
                         dbo.Users AS USERS ON UFI.fk_UserID = USERS.pk_UserID INNER JOIN
                         dbo.FishTypes AS FISHTYPES ON UFI.fk_FishType = FISHTYPES.pk_FishTypeID INNER JOIN
                         dbo.UserPurchases AS PURCHASES ON UFI.fk_UserPurchaseID = PURCHASES.pk_PurchaseID INNER JOIN
                         dbo.UserTanks AS FISHTANKS ON UFI.fk_UserTank = FISHTANKS.pk_UserTankID INNER JOIN
                         dbo.List_WaterTypes AS WATERTYPES ON FISHTYPES.fk_WaterType = WATERTYPES.pk_WaterTypeID INNER JOIN
                         dbo.List_FishColors AS COLORS2 ON ISNULL(UF.fk_fishColorSecondary, 18) = COLORS2.pk_colorID INNER JOIN
                         dbo.Stores AS STORES ON PURCHASES.fk_StoreID = STORES.pk_StoreID INNER JOIN
                         dbo.List_FishTerritorialLevels AS TERRITORY ON FISHTYPES.fk_FishTerritorialLevel = TERRITORY.pk_TerritorialLevelID INNER JOIN
                         dbo.List_FishAgressionLevels AS AGRESSIVENESS ON FISHTYPES.fk_FishAgressionLevel = AGRESSIVENESS.pk_AgressionLevelID INNER JOIN
                         dbo.List_FishFeedingTypes AS FEEDTYPE ON FISHTYPES.fk_FishFeederType = FEEDTYPE.pk_FeedingTypeID INNER JOIN
                         dbo.List_FishBirthingTypes AS BIRTH ON FISHTYPES.fk_BirthingType = BIRTH.pk_BirthTypeID LEFT OUTER JOIN
                         dbo.UserFishMedicalRecords AS FISHMEDICAL ON UF.pk_UserFishID = FISHMEDICAL.fk_FishID

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[59] 4[3] 2[11] 3) )"
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
         Begin Table = "UF"
            Begin Extent = 
               Top = 10
               Left = 285
               Bottom = 242
               Right = 480
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UFI"
            Begin Extent = 
               Top = 209
               Left = 510
               Bottom = 375
               Right = 681
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "COLORS"
            Begin Extent = 
               Top = 334
               Left = 107
               Bottom = 433
               Right = 256
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "USERS"
            Begin Extent = 
               Top = 0
               Left = 712
               Bottom = 165
               Right = 882
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FISHTYPES"
            Begin Extent = 
               Top = 277
               Left = 769
               Bottom = 544
               Right = 1015
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "PURCHASES"
            Begin Extent = 
               Top = 21
               Left = 1016
               Bottom = 236
               Right = 1216
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FISHTANKS"
            Begin Extent = 
               Top = 293
               Left = 290
               Bottom = 510
               Right = 460
            End
            DisplayFlags = 280
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_MasterFishView';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'            TopColumn = 3
         End
         Begin Table = "WATERTYPES"
            Begin Extent = 
               Top = 448
               Left = 1312
               Bottom = 561
               Right = 1507
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "COLORS2"
            Begin Extent = 
               Top = 0
               Left = 108
               Bottom = 97
               Right = 255
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "STORES"
            Begin Extent = 
               Top = 71
               Left = 1314
               Bottom = 234
               Right = 1534
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TERRITORY"
            Begin Extent = 
               Top = 346
               Left = 1313
               Bottom = 442
               Right = 1510
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "AGRESSIVENESS"
            Begin Extent = 
               Top = 244
               Left = 1313
               Bottom = 340
               Right = 1510
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FEEDTYPE"
            Begin Extent = 
               Top = 247
               Left = 1045
               Bottom = 343
               Right = 1215
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "BIRTH"
            Begin Extent = 
               Top = 449
               Left = 569
               Bottom = 562
               Right = 739
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "FISHMEDICAL"
            Begin Extent = 
               Top = 113
               Left = 15
               Bottom = 275
               Right = 235
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
      Begin ColumnWidths = 46
         Width = 284
         Width = 735
         Width = 1065
         Width = 630
         Width = 2145
         Width = 1365
         Width = 1425
         Width = 1200
         Width = 1035
         Width = 1500
         Width = 1005
         Width = 885
         Width = 1350
         Width = 1305
         Width = 75
         Width = 1200
         Width = 1635
         Width = 870
         Width = 1185
         Width = 1395
         Width = 1170
         Width = 1140
         Width = 1245
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
         Width = 1500
         Width = 1500
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
      E', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_MasterFishView';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane3', @value = N'nd
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_MasterFishView';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 3, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_MasterFishView';

