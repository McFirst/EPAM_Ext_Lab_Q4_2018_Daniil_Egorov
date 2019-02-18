USE [Northwind]
go

--ÌÂ ‡·ÓÚ‡ÂÚ
--DROP PROCEDURE IF EXISTS [dbo].[GreatestOrders]
IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'GreatestOrders')
BEGIN
    DROP PROCEDURE [dbo].[GreatestOrders]
END
go

CREATE PROCEDURE [dbo].[GreatestOrders]
AS
	DECLARE @msg nvarchar(2048); 
	SET @msg = 'Custom error: ' + 'first†param';

	--THROW 50001, @msg , 1;
RETURN 0


--exec [dbo].[GreatestOrders]