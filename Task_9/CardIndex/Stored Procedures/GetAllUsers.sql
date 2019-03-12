CREATE PROCEDURE [dbo].[GetAllUsers]
	@amt int = 35
AS
	SELECT TOP(@amt) [UserID],[LastName],[FirstName],[E-mail],[Login],[BirthDate],[RgistrationDate],[Password]
	FROM [Users]