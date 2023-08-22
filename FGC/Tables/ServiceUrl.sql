CREATE TABLE [dbo].[ServiceUrl](
	[ServiceUrlId] [int] IDENTITY(1,1) NOT NULL,
	[DateCreated] [smalldatetime] NULL,
	[ServiceUrl] [nvarchar](255) NULL,
	[ServiceName] [nvarchar](255) NULL,
	[ServiceSource] [int] NOT NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceUrlId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ServiceUrl] ADD  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[ServiceUrl] ADD  DEFAULT ((1)) FOR [Active]