﻿CREATE TABLE [dbo].[IRCCharityExclusion](
	[IRCCharityId] [int] IDENTITY(1,1) NOT NULL,
	[CharityNumber] [nvarchar](255) NULL,
	[CharityName] [nvarchar](4000) NULL,
PRIMARY KEY CLUSTERED 
(
	[IRCCharityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]