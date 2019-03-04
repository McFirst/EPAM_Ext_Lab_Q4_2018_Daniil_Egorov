
DECLARE @device_directory NVARCHAR(520)
SELECT @device_directory = SUBSTRING(filename, 1, CHARINDEX(N'master.mdf', LOWER(filename)) - 1)
FROM master.dbo.sysaltfiles WHERE dbid = 1 AND fileid = 1

EXECUTE (N'CREATE DATABASE CardIndex
  ON PRIMARY (NAME = N''CardIndex'', FILENAME = N''' + @device_directory + N'CardIndex.mdf'')
  LOG ON (NAME = N''CardIndex_log'',  FILENAME = N''' + @device_directory + N'CardIndex.ldf'')')
go

USE CardIndex
GO

--
-- Definition for table Roles : 
--

CREATE TABLE dbo.Roles (
  RoleID int NOT NULL,
  Title nvarchar(20) COLLATE Cyrillic_General_CI_AS NOT NULL,
  Description nvarchar(max) COLLATE Cyrillic_General_CI_AS NULL
)
ON [PRIMARY]
GO

--
-- Definition for table UserRoles : 
--

CREATE TABLE dbo.UserRoles (
  UsersID int NOT NULL,
  RoleID int NOT NULL
)
ON [PRIMARY]
GO

--
-- Definition for table Users : 
--

CREATE TABLE dbo.Users (
  UsersID int NOT NULL,
  LastName nvarchar(50) COLLATE Cyrillic_General_CI_AS NOT NULL,
  FirstName nvarchar(50) COLLATE Cyrillic_General_CI_AS NOT NULL,
  [E-mail] nvarchar(50) COLLATE Cyrillic_General_CI_AS NOT NULL,
  Login nvarchar(50) COLLATE Cyrillic_General_CI_AS NOT NULL,
  BirthDate datetime NULL,
  RgistrationDate datetime NOT NULL,
  Password nvarchar(50) COLLATE Cyrillic_General_CI_AS NOT NULL,
  CONSTRAINT PK_Users PRIMARY KEY CLUSTERED (UsersID)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

insert into Users Values
	(1,N'Davolio',N'Nancy',N'n.davolio@mail.com',N'admin','12/08/1948','05/01/1992','')
	(2,N'Fuller',N'Andrew',N'a.fuller@mail.com',N'andy','19/02/1952','14/08/1992',''),
	(3,N'Leverling',N'Janet',N'j.leverling@mail.com',N'jany','30/08/1963','04/01/1992',''),
	(4,N'Peacock',N'Margaret',N'm.peacock@mail.com',N'marge','19/09/1937','05/03/1993',''),
	(5,N'Buchanan',N'Steven',N's.buchanan@mail.com',N'steen','03/04/1955','17/10/1993',''),
	(6,N'Suyama',N'Michael',N'm.suyama@mail.com',N'mach','07/02/1963','17/10/1993',''),
	(7,N'King',N'Robert',N'r.king@mail.com',N'robi','29/05/1960','01/02/1994',''),
	(8,N'Callahan',N'Laura',N'l.callahan@mail.com',N'lara','01/09/1958','03/05/1994',''),
	(9,N'Dodsworth',N'Anne',N'a.dodsworth@mail.com',N'annete','27/01/1966','15/11/1994',''),
	(10,'Adam','Sinkler','a.sinkler@mail.com','sadom','30.06.1966 0:00:00','30.06.1976 0:00:00','');