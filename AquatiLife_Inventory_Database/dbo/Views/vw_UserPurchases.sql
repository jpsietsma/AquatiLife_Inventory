﻿CREATE VIEW dbo.vw_UserPurchases
AS
SELECT        dbo.UserPurchases.pk_PurchaseID, dbo.UserPurchases.Date, dbo.UserPurchases.Quantity, stores.StoreName, purchaseCategory.PurchaseTypeDescription AS PurchaseCategory, dbo.UserPurchases.Cost, 
                         users.UserName AS FishOwner, dbo.UserPurchases.Description AS PurchaseDescription, dbo.UserPurchases.ExtCost, dbo.UserPurchases.fk_UserFish, dbo.UserPurchases.fk_UserSupplyInventory, 
                         dbo.UserPurchases.fk_UserTank, dbo.UserPurchases.fk_UserPlant
FROM            dbo.UserPurchases INNER JOIN
                         dbo.Stores AS stores ON dbo.UserPurchases.fk_StoreID = stores.pk_StoreID INNER JOIN
                         dbo.List_PurchaseCategories AS purchaseCategory ON dbo.UserPurchases.fk_PurchaseCategory = purchaseCategory.pk_PurchaseTypeID INNER JOIN
                         dbo.Users AS users ON dbo.UserPurchases.fk_UserID = users.pk_UserID

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
         Begin Table = "UserPurchases"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 298
               Right = 251
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "stores"
            Begin Extent = 
               Top = 6
               Left = 289
               Bottom = 136
               Right = 509
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "purchaseCategory"
            Begin Extent = 
               Top = 6
               Left = 547
               Bottom = 102
               Right = 769
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "users"
            Begin Extent = 
               Top = 154
               Left = 376
               Bottom = 284
               Right = 546
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
      Begin ColumnWidths = 14
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2670
         Width = 1800
         Width = 1500
         Width = 1500
         Width = 2295
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2100
         Alias = 600
         Table = 1590
         Output = 840
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_UserPurchases';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_UserPurchases';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_UserPurchases';
