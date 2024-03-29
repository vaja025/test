﻿CREATE TABLE [dbo].[RC_MEMBER_LOOKUP](
	[OWNER] [varchar](50) NULL,
	[FAMILY_NAME] [varchar](100) NULL,
	[GIVEN_NAME] [varchar](200) NULL,
	[POSTCODE] [varchar](50) NULL,
	[BLANKET_GA_DECL_FLAG] [varchar](1) NULL,
	[PER_NUM] [varchar](50) NULL,
	[ADDRESS1] [varchar](500) NULL,
	[ADDRESS2] [varchar](500) NULL,
	[ADDRESS3] [varchar](500) NULL,
	[ADDRESS4] [varchar](500) NULL,
	[ADDRESS5] [varchar](500) NULL,
	[TITLE] [varchar](50) NULL,
	[INITIALS] [varchar](50) NULL,
	[DOB] [varchar](50) NULL,
	[LODGE_LIST] [varchar](100) NULL,
	[BANK_ACC] [varchar](50) NULL,
	[SORT_CODE] [varchar](50) NULL,
	[UPPER_GIVEN_NAME] [varchar](100) NULL,
	[UPPER_FAMILY_NAME] [varchar](200) NULL,
	[DATE_CREATED] [datetime] NULL
) ON [PRIMARY]