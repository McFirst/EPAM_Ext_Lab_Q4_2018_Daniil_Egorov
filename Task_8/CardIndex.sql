-- SQL Manager for SQL Server 4.3.0.47830
-- ---------------------------------------
-- Хост         : pc039
-- База данных  : CardIndex
-- Версия       : Microsoft SQL Server 2008 R2 (RTM) 10.50.1600.1


CREATE DATABASE CardIndex
ON PRIMARY
  ( NAME = CardIndex,
    FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CardIndex.mdf',
    SIZE = 3 MB,
    MAXSIZE = UNLIMITED,
    FILEGROWTH = 1 MB )
LOG ON
  ( NAME = CardIndex_log,
    FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CardIndex_log.ldf',
    SIZE = 1 MB,
    MAXSIZE = 2097152 MB,
    FILEGROWTH = 10 % )
COLLATE Cyrillic_General_CI_AS
GO

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

