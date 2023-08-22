CREATE TABLE [dbo].[Audit](
	[AuditId] [int] IDENTITY(1,1) NOT NULL,
	[Severity] [int] NOT NULL,
	[Comment] [nvarchar](max) NOT NULL,
	[FurtherInfo] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ActiveUser] [nvarchar](100) NOT NULL,
 [FriendlyMessage] NVARCHAR(MAX) NULL, 
    [LinkedIdentifier] UNIQUEIDENTIFIER NULL, 
    [Filename] NVARCHAR(255) NULL, 
    CONSTRAINT [PK_Audit_] PRIMARY KEY CLUSTERED 
(
	[AuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Audit] ADD  CONSTRAINT [DF_Audit_CreatedDate_]  DEFAULT (getdate()) FOR [CreatedDate]
GO
CREATE NONCLUSTERED INDEX IX_Audit_Filename ON dbo.Audit
	(
	AuditId
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO