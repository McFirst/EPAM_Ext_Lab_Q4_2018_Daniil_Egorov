USE [Northwind]
go

--не работает
--DROP PROCEDURE IF EXISTS [dbo].[GreatestOrders]
IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'GreatestOrders')
BEGIN
    DROP PROCEDURE [dbo].[GreatestOrders]
END
go

CREATE PROCEDURE [dbo].[GreatestOrders]
	@TopRec int,   
    @Year int
AS
	SELECT TOP (@TopRec) [Employees].[FirstName]+' '+[Employees].[LastName] AS [Employee] 
		, [Orders].[OrderID]
		, MAX([Order Details].[UnitPrice]*[Order Details].[Quantity]*(1-[Order Details].[Discount])) AS [OrderCoast]
	FROM [Orders] INNER JOIN [Employees] ON [Orders].[EmployeeID] = [Employees].[EmployeeID]
		INNER JOIN [Order Details] ON [Orders].[OrderID] = [Order Details].[OrderID]
	WHERE Year([Orders].[OrderDate]) = @Year
	GROUP BY [Employees].[FirstName]+' '+[Employees].[LastName]
		, [Orders].[OrderID]
	ORDER BY [OrderCoast] DESC
go

--DROP PROCEDURE IF EXISTS [dbo].[ShippedOrdersDiff];
IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'ShippedOrdersDiff')
BEGIN
    DROP PROCEDURE [dbo].[ShippedOrdersDiff]
END
go

CREATE PROCEDURE [dbo].[ShippedOrdersDiff]
	@ShipDay int = 35
AS
	SELECT [OrderID], [OrderDate], [ShippedDate], DAY([ShippedDate] - [OrderDate]) AS [ShippedDelay] 
	FROM [Orders]
	WHERE DAY([ShippedDate] - [OrderDate]) > @ShipDay OR [ShippedDate] IS NULL

GO