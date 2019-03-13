CREATE TABLE [dbo].[Tags](
	[TagID] [int] IDENTITY(1,1) NOT NULL,
	[NameTag] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED 
(
	[TagID] ASC
)
)