USE [Northwind]
go

------13.1
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

------13.2
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

------13.3
--DROP PROCEDURE IF EXISTS [dbo].[SubordinationInfo];
IF EXISTS(SELECT 1 FROM sys.procedures WHERE Name = 'SubordinationInfo')
BEGIN
    DROP PROCEDURE [dbo].[SubordinationInfo]
END
go

CREATE PROCEDURE [dbo].[SubordinationInfo]
	@EmplID int = 2
AS
	DECLARE @EmpName nvarchar(50)
		, @EmpID int
		, @RepID int
		, @Emplvl int;

	DECLARE emp_cursor CURSOR FOR
	WITH [EmployeeTree]([Name], [EmployeeID], [ReportsTo], [EmployeeLevel], [PATHSTR]) AS   
	(
		SELECT [FirstName]+' '+[LastName], [EmployeeID], [ReportsTo], 0, CAST('' AS NVARCHAR(MAX))
		FROM [dbo].[Employees]
		WHERE [EmployeeID]=@EmplID	--[ReportsTo] is null
		UNION ALL
		SELECT e.[FirstName]+' '+e.[LastName], e.[EmployeeID], e.[ReportsTo], t.[EmployeeLevel] + 4, t.[PATHSTR] + e.[FirstName]+' '+e.[LastName]
		FROM [dbo].[Employees] AS e
			INNER JOIN [EmployeeTree] AS t
			ON e.[ReportsTo] = t.[EmployeeID]
	)
	SELECT SPACE([EmployeeLevel])+[Name] AS [Name], [EmployeeID], [ReportsTo], [EmployeeLevel]
	FROM [EmployeeTree]
	ORDER BY [PATHSTR], [EmployeeID]

	OPEN emp_cursor

	FETCH NEXT FROM emp_cursor
	INTO @EmpName, @EmpID, @RepID, @Emplvl
	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		PRINT @EmpName
		FETCH NEXT FROM emp_cursor
		INTO @EmpName, @EmpID, @RepID, @Emplvl
	END
	CLOSE emp_cursor;
	DEALLOCATE emp_cursor;
GO

------13.4
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