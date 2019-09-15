CREATE VIEW dbo.vw_UserOverview
AS
SELECT        users.pk_UserID AS UserID, users.UserName, users.Password, users.EmailAddress, users.UserRole, contact.FirstName, contact.LastName, contact.FirstName + ' ' + contact.LastName AS FullName_FL, 
                         contact.LastName + ', ' + contact.FirstName AS FullName_LF, contact.StreetAddress, contact.City, contact.State, contact.ZipCode, '(' + SUBSTRING(contact.PhoneNumber, 1, 3) + ') ' + SUBSTRING(contact.PhoneNumber, 4, 3) 
                         + '-' + SUBSTRING(contact.PhoneNumber, 7, 4) AS PhoneFormatted, contact.PhoneNumber, contact.AltEmail, contact.Website, types.ContactTypeDisplayName, permissions.AddProgramUsers, permissions.AddPurchase, 
                         permissions.AddSupply, permissions.AddDecoration, permissions.AddFish, permissions.AddLivePlant, permissions.AddTank, permissions.EditProgramUsers, permissions.EditPurchases, permissions.EditSupply, 
                         permissions.EditDecorations, permissions.EditFish, permissions.EditTanks, permissions.EditLivePlants, permissions.ViewGlobalPurchases, permissions.DeleteProgramUsers, permissions.DeletePurchases, 
                         permissions.DeleteSupply, permissions.DeleteDecoration, permissions.DeleteFish, permissions.DeletePlants, permissions.DeleteTanks, permissions.RecordDeath, permissions.RecordGlobalDeath, 
                         permissions.PerformMaintenance, permissions.PerformGlobalMaintenance, permissions.LoginWeb, permissions.LoginMobile, permissions.LoginAPI
FROM            dbo.Users AS users INNER JOIN
                         dbo.UserProfiles AS profiles ON users.fk_ProfileID = profiles.pk_ProfileID INNER JOIN
                         dbo.ContactInfo AS contact ON profiles.fk_ContactInfo = contact.pk_ContactID INNER JOIN
                         dbo.List_ContactTypes AS types ON contact.fk_ContactType = types.pk_ContactType INNER JOIN
                         dbo.UserPermissions AS permissions ON profiles.fk_UserPermissions = permissions.pk_PermissionID
WHERE        (contact.fk_StoreID IS NULL)

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[55] 4[6] 2[20] 3) )"
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
         Begin Table = "types"
            Begin Extent = 
               Top = 407
               Left = 531
               Bottom = 503
               Right = 757
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "contact"
            Begin Extent = 
               Top = 124
               Left = 786
               Bottom = 411
               Right = 961
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "profiles"
            Begin Extent = 
               Top = 91
               Left = 315
               Bottom = 221
               Right = 497
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "users"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 173
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "permissions"
            Begin Extent = 
               Top = 224
               Left = 527
               Bottom = 354
               Right = 762
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
      Begin ColumnWidths = 48
         Width = 284
         Width = 990
         Width = 1500
         Width = 1500
         Width = 2535
         Width = 1215
         Width = 1200
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 885
         Width = 690
         Width = 1020
         Width ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_UserOverview';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'= 1605
         Width = 1530
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
         Width = 1965
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1950
         Width = 2055
         Width = 2550
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
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_UserOverview';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_UserOverview';

