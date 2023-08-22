CREATE VIEW [dbo].[FileDirector_GAE]
AS
(SELECT     TOP 100 PERCENT RPP_DOC_REF AS URN, '' AS ParentURN, 'Single Donation' AS DocType, DATE_SIGNED AS DateSigned, SINGLE_ORG_NAME AS LodgeName, 
                      SINGLE_MASONIC_ORG_CODE AS LodgeNum, NULL AS ChestName, SINGLE_CHEST_NUMBER AS ChestNum, SINGLE_AMOUNT AS Amount, 
                      DONOR_NAME AS DonorName, POSTCODE AS DonorPostcode, Notes
FROM         dbo.RC_ST_EDRMS_RPP
WHERE SCANNED_DATE > '2017-04-30')
UNION
(SELECT     TOP 100 PERCENT ENVELOPE_DOC_REF AS URN, SCHEDULE_SCHEDULE_DOC_REF AS ParentURN, 'Gift Aid Envelopes' AS DocType, 
                        DATE_SIGNED AS DateSigned, MASONIC_ORG_NAME AS LodgeName, ORG_CODE AS LodgeNum, CHEST_NAME AS ChestName, CHEST_NUMBER AS ChestNum, 
                        AMOUNT AS Amount, DONOR_NAME AS DonorName, POSTCODE AS DonorPostcode, '' AS Notes
 FROM         dbo.RC_ST_EDRMS_GA_ENVELOPE
WHERE SCANNED_DATE > '2017-04-30')
UNION
(SELECT     TOP 100 PERCENT SCHEDULE_DOC_REF AS URN, '' AS ParentURN, 'Gift Aid Envelopes' AS DocType, DATE_SIGNED AS DateSigned, ORG_NAME AS LodgeName, 
                        MASONIC_ORG_CODE AS LodgeNum, CHEST_NAME AS ChestName, CHEST_NUMBER AS ChestNum, AMOUNT AS Amount, DONOR_NAME AS DonorName, 
                        POSTCODE AS DonorPostcode, '' AS Notes
 FROM         dbo.RC_ST_EDRMS_GA_SCHEDULE
WHERE SCANNED_DATE > '2017-04-30')
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[16] 2[25] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[30] 2[40] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2[66] 3) )"
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
         Configuration = "(H (1 [56] 4 [18] 2))"
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
      ActivePaneConfig = 5
   End
   Begin DiagramPane = 
      PaneHidden = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
         Width = 1440
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FileDirector_GAE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'FileDirector_GAE'