﻿CREATE VIEW [dbo].[Check_Output]
AS
SELECT     TOP 100 PERCENT DATA_TABLE_NAME, FIELD_NAME, REQUIRED_FILE_DIRECTOR_FLAG, OUTPUT_ORDER
FROM         dbo.GC_FIELD_INFO
WHERE     (DATA_TABLE_NAME = 'RC_ST_EDRMS_NORMAL')
ORDER BY OUTPUT_ORDER