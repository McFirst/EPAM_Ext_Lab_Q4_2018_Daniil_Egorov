CREATE PROCEDURE [dbo].[GetAllUsers]
	@amt int = 35
AS
<<<<<<< HEAD
	SELECT TOP(@amt) [UserID],[LastName],[FirstName],[E-mail],[Login],[BirthDate],[RegistrationDate],[Password]
=======
	SELECT TOP(@amt) [UserID],[LastName],[FirstName],[E-mail],[Login],[BirthDate],[RgistrationDate],[Password]
>>>>>>> 4301ea3575872b72eadb2bb7e754407a40b20ada
	FROM [Users]