CREATE TABLE [dbo].[Users](
<<<<<<< HEAD
	[UserID] [int] IDENTITY(1,1) NOT NULL,
=======
	[UserID] [int] NOT NULL,
>>>>>>> 4301ea3575872b72eadb2bb7e754407a40b20ada
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
<<<<<<< HEAD
)
)
=======
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
>>>>>>> 4301ea3575872b72eadb2bb7e754407a40b20ada
