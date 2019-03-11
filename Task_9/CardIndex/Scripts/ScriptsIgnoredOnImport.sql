
USE [CardIndex]
GO

/****** Object:  Table [dbo].[MaterialRaiting]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Materials]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[MaterialTag]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Raitings]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Roles]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Tags]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[UserRoles]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Users]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (1, N'Davolio', N'Nancy', N'n.davolio@mail.com', N'admin', CAST(N'1948-08-12 00:00:00.000' AS DateTime), CAST(N'1992-01-05 00:00:00.000' AS DateTime), N'')
GO

INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (2, N'Fuller', N'Andrew', N'a.fuller@mail.com', N'andy', CAST(N'1952-02-19 00:00:00.000' AS DateTime), CAST(N'1992-08-14 00:00:00.000' AS DateTime), N'')
GO

INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (3, N'Leverling', N'Janet', N'j.leverling@mail.com', N'jany', CAST(N'1963-08-30 00:00:00.000' AS DateTime), CAST(N'1992-01-04 00:00:00.000' AS DateTime), N'')
GO

INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (4, N'Peacock', N'Margaret', N'm.peacock@mail.com', N'marge', CAST(N'1937-09-19 00:00:00.000' AS DateTime), CAST(N'1993-03-05 00:00:00.000' AS DateTime), N'')
GO

INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (5, N'Buchanan', N'Steven', N's.buchanan@mail.com', N'steen', CAST(N'1955-04-03 00:00:00.000' AS DateTime), CAST(N'1993-10-17 00:00:00.000' AS DateTime), N'')
GO

INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (6, N'Suyama', N'Michael', N'm.suyama@mail.com', N'mach', CAST(N'1963-02-07 00:00:00.000' AS DateTime), CAST(N'1993-10-17 00:00:00.000' AS DateTime), N'')
GO

INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (7, N'King', N'Robert', N'r.king@mail.com', N'robi', CAST(N'1960-05-29 00:00:00.000' AS DateTime), CAST(N'1994-02-01 00:00:00.000' AS DateTime), N'')
GO

INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (8, N'Callahan', N'Laura', N'l.callahan@mail.com', N'lara', CAST(N'1958-09-01 00:00:00.000' AS DateTime), CAST(N'1994-05-03 00:00:00.000' AS DateTime), N'')
GO

INSERT [dbo].[Users] ([UsersID], [LastName], [FirstName], [E-mail], [Login], [BirthDate], [RgistrationDate], [Password]) VALUES (9, N'Dodsworth', N'Anne', N'a.dodsworth@mail.com', N'annete', CAST(N'1966-01-27 00:00:00.000' AS DateTime), CAST(N'1994-11-15 00:00:00.000' AS DateTime), N'')
GO

/****** Object:  StoredProcedure [dbo].[GetAllUsers]    Script Date: 11.03.2019 22:31:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
