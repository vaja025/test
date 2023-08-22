CREATE TABLE [dbo].[FileDirector_frequencyTranslation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[frequency] [int] NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_FileDirector_frequencyTranslation_] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]