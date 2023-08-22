CREATE VIEW [dbo].[DonationTotalsByDate]
AS
SELECT        TOP (100) PERCENT SUM(DonationAmount) AS DonationAmountTotal, DonationStartDate
FROM            dbo.[Transaction]
GROUP BY DonationStartDate
ORDER BY DonationAmountTotal