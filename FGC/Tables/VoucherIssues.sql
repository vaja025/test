﻿CREATE TABLE [dbo].[VoucherIssues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[urn] [varchar](100) NOT NULL,
 CONSTRAINT [PK_VoucherIssues] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]