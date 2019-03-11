CREATE TABLE [dbo].[Materials](
	[MaterialID] [int] NOT NULL,
	[Autor] [nvarchar](50) NOT NULL,
	[Caption] [nvarchar](50) NOT NULL,
	[DatePublicution] [date] NOT NULL,
	[Path] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Materials] PRIMARY KEY CLUSTERED 
(
	[MaterialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]