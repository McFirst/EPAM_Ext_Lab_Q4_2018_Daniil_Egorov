USE [CardIndex]
GO
/****** Object:  Table [dbo].[MaterialRaiting]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialRaiting](
	[MaterialID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[RaitingID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Materials]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
/****** Object:  Table [dbo].[MaterialTag]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialTag](
	[MaterialID] [int] NOT NULL,
	[TagID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Raitings]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raitings](
	[RaitingID] [int] NOT NULL,
	[RaitingValue] [int] NOT NULL,
 CONSTRAINT [PK_Raitings] PRIMARY KEY CLUSTERED 
(
	[RaitingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roles]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] NOT NULL,
	[Title] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tags]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[TagID] [int] NOT NULL,
	[NameTag] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED 
(
	[TagID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[UsersID] [int] NOT NULL,
	[RoleID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UsersID] [int] NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[E-mail] [nvarchar](50) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[BirthDate] [datetime] NULL,
	[RgistrationDate] [datetime] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UsersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (1, N'Davolio', N'Nancy', N'n.davolio@mail.com', N'admin', CAST(N'1948-08-12 00:00:00.000' AS DateTime), CAST(N'1992-01-05 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (2, N'Fuller', N'Andrew', N'a.fuller@mail.com', N'andy', CAST(N'1952-02-19 00:00:00.000' AS DateTime), CAST(N'1992-08-14 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (3, N'Leverling', N'Janet', N'j.leverling@mail.com', N'jany', CAST(N'1963-08-30 00:00:00.000' AS DateTime), CAST(N'1992-01-04 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (4, N'Peacock', N'Margaret', N'm.peacock@mail.com', N'marge', CAST(N'1937-09-19 00:00:00.000' AS DateTime), CAST(N'1993-03-05 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (5, N'Buchanan', N'Steven', N's.buchanan@mail.com', N'steen', CAST(N'1955-04-03 00:00:00.000' AS DateTime), CAST(N'1993-10-17 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (6, N'Suyama', N'Michael', N'm.suyama@mail.com', N'mach', CAST(N'1963-02-07 00:00:00.000' AS DateTime), CAST(N'1993-10-17 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (7, N'King', N'Robert', N'r.king@mail.com', N'robi', CAST(N'1960-05-29 00:00:00.000' AS DateTime), CAST(N'1994-02-01 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (8, N'Callahan', N'Laura', N'l.callahan@mail.com', N'lara', CAST(N'1958-09-01 00:00:00.000' AS DateTime), CAST(N'1994-05-03 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (9, N'Dodsworth', N'Anne', N'a.dodsworth@mail.com', N'annete', CAST(N'1966-01-27 00:00:00.000' AS DateTime), CAST(N'1994-11-15 00:00:00.000' AS DateTime), N'')
ALTER TABLE [dbo].[MaterialRaiting]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRaiting_Materials] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Materials] ([MaterialID])
GO
ALTER TABLE [dbo].[MaterialRaiting] CHECK CONSTRAINT [FK_MaterialRaiting_Materials]
GO
ALTER TABLE [dbo].[MaterialRaiting]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRaiting_Raitings] FOREIGN KEY([UserID])
REFERENCES [dbo].[Raitings] ([RaitingID])
GO
ALTER TABLE [dbo].[MaterialRaiting] CHECK CONSTRAINT [FK_MaterialRaiting_Raitings]
GO
ALTER TABLE [dbo].[MaterialRaiting]  WITH CHECK ADD  CONSTRAINT [FK_MaterialRaiting_Users] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Users] ([UsersID])
GO
ALTER TABLE [dbo].[MaterialRaiting] CHECK CONSTRAINT [FK_MaterialRaiting_Users]
GO
ALTER TABLE [dbo].[MaterialTag]  WITH CHECK ADD  CONSTRAINT [FK_MaterialTag_Materials] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Materials] ([MaterialID])
GO
ALTER TABLE [dbo].[MaterialTag] CHECK CONSTRAINT [FK_MaterialTag_Materials]
GO
ALTER TABLE [dbo].[MaterialTag]  WITH CHECK ADD  CONSTRAINT [FK_MaterialTag_Tags] FOREIGN KEY([TagID])
REFERENCES [dbo].[Tags] ([TagID])
GO
ALTER TABLE [dbo].[MaterialTag] CHECK CONSTRAINT [FK_MaterialTag_Tags]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Users] FOREIGN KEY([UsersID])
REFERENCES [dbo].[Users] ([UsersID])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Users]
GO
/****** Object:  StoredProcedure [dbo].[GetAllUsers]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllUsers]
	@amt int = 35
AS
	SELECT TOP(@amt) [UsersID],[LastName],[FirstName],[E-mail],[Login],[BirthDate],[RgistrationDate],[Password]
	FROM [Users]

GO
