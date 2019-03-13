CREATE TABLE [dbo].[Materials](
	[MaterialID] [int] IDENTITY(1,1) NOT NULL,
	[Autor] [nvarchar](50) NOT NULL,
	[Caption] [nvarchar](50) NOT NULL,
	[DatePublicution] [date] NOT NULL,
	[Path] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Materials] PRIMARY KEY CLUSTERED 
(
	[MaterialID] ASC
)
)