CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[E-mail] [nvarchar](50) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[BirthDate] [datetime] NULL,
	[RegistrationDate] [datetime] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)
)