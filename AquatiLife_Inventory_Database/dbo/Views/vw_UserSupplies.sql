CREATE VIEW dbo.vw_UserSupplies
AS
SELECT        dbo.UserPurchases.pk_PurchaseID, dbo.UserPurchases.Date, dbo.UserPurchases.Description AS PurchaseDescription, dbo.UserPurchases.Quantity, dbo.UserPurchases.Cost, dbo.UserPurchases.ExtCost, stores.StoreName, 
                         purchaseCategory.PurchaseTypeDescription AS PurchaseCategory, tanks.TankDisplayName AS SupplyTank, users.UserName AS Owner, supplies.QuantityOnHand AS OnHand
FROM            dbo.UserPurchases INNER JOIN
                         dbo.Stores AS stores ON dbo.UserPurchases.fk_StoreID = stores.pk_StoreID INNER JOIN
                         dbo.List_PurchaseCategories AS purchaseCategory ON dbo.UserPurchases.fk_PurchaseCategory = purchaseCategory.pk_PurchaseTypeID INNER JOIN
                         dbo.Users AS users ON dbo.UserPurchases.fk_UserID = users.pk_UserID INNER JOIN
                         dbo.UserTankSupplyInventory AS supplies ON dbo.UserPurchases.fk_UserSupplyInventory = supplies.pk_SupplyID INNER JOIN
                         dbo.UserTanks AS tanks ON supplies.fk_UserTankID = tanks.pk_UserTankID

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[60] 4[4] 2[16] 3) )"
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
         Begin Table = "UserPurchases"
            Begin Extent = 
               Top = 0
               Left = 1
               Bottom = 305
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "stores"
            Begin Extent = 
               Top = 3
               Left = 598
               Bottom = 171
               Right = 818
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "purchaseCategory"
            Begin Extent = 
               Top = 154
               Left = 834
               Bottom = 250
               Right = 1056
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "users"
            Begin Extent = 
               Top = 199
               Left = 503
               Bottom = 365
               Right = 673
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "supplies"
            Begin Extent = 
               Top = 310
               Left = 243
               Bottom = 480
               Right = 423
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tanks"
            Begin Extent = 
               Top = 378
               Left = 502
               Bottom = 508
               Right = 688
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
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width =', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_UserSupplies';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' 1500
         Width = 2625
         Width = 990
         Width = 1830
         Width = 1500
         Width = 1500
         Width = 1905
         Width = 1500
         Width = 1665
         Width = 945
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_UserSupplies';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_UserSupplies';

