CREATE TABLE [dbo].[RC_GAE_SCHEDULES](
	[URN] [nvarchar](100) NOT NULL,
	[LodgeCascade] [bit] NULL,
	[LodgeName] [nvarchar](255) NULL,
	[LodgeNum] [nvarchar](50) NULL,
	[ChestName] [nvarchar](255) NULL,
	[ChestNum] [nvarchar](50) NULL,
	[DateStamp] [datetime] NULL,
	[CascadeDate] [bit] NULL,
	[ScheduleDate] [datetime] NULL,
 CONSTRAINT [PK_RC_GAE_SCHEDULES_] PRIMARY KEY CLUSTERED 
(
	[URN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RC_GAE_SCHEDULES] ADD  CONSTRAINT [DF_RC_GAE_SCHEDULES_TimeStamp_]  DEFAULT (getdate()) FOR [DateStamp]