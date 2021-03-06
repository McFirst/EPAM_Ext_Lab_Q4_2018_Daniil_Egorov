
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

