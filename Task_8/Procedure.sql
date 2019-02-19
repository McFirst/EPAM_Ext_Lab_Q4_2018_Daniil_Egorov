USE [Northwind]
go

--не работает
--DROP PROCEDURE [dbo].[GreatestOrders] IF EXISTS([GreatestOrders])
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

--DROP PROCEDURE IF EXISTS [dbo].[SubordinationInfo];
IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'SubordinationInfo')
BEGIN
    DROP PROCEDURE [dbo].[SubordinationInfo]
END
go

CREATE PROCEDURE [dbo].[SubordinationInfo]
	@EmplID int = 2
AS
	WITH [DirectReports]([ReportsTo], [EmployeeID], [Title], [EmployeeLevel]) AS   
(  
    SELECT [ReportsTo], [EmployeeID], [FirstName]+' '+[LastName] AS [Title], 0 AS [EmployeeLevel]  
    FROM [dbo].[Employees]
    WHERE [EmployeeID]=@EmplID	--[ReportsTo] is null
    UNION ALL  
    SELECT e.[ReportsTo], e.[EmployeeID], e.[FirstName]+' '+e.[LastName] AS [Title], [EmployeeLevel] + 1  
    FROM [dbo].[Employees] AS e  
        INNER JOIN [DirectReports] AS d  
        ON e.[ReportsTo] = d.[EmployeeID]   
)  
SELECT [ReportsTo], [EmployeeID], [Title], [EmployeeLevel]   
FROM [DirectReports]
ORDER BY [EmployeeLevel]
GO

--DROP FUNCTION IF EXISTS [dbo].[IsBoss];
IF object_id(N'IsBoss', N'FN') IS NOT NULL
    DROP FUNCTION [dbo].[IsBoss]
GO

CREATE FUNCTION [dbo].[IsBoss](@EmplID int = 2)
	RETURNS bit
AS
BEGIN
	DECLARE @ret bit;
	SET @ret = 1;  
	IF (SELECT top 1 [EmployeeID]
		FROM [dbo].[Employees]
		WHERE [ReportsTo] = @EmplID
		) is NULL
		SET @ret = 0;
	RETURN @ret;
END;
GO