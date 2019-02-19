use [Northwind]
go
--TASK_8.1
----1.1
/*SELECT [OrderID], [ShippedDate], [ShipVia]
FROM [dbo].[Orders]
WHERE [ShippedDate] >= CONVERT(DATETIME, '1998-05-06', 120) AND [ShipVia] >= 2
*/
----1.2
/*SELECT [OrderID], 
CASE 
 WHEN [ShippedDate] IS NULL 
 THEN 'Not Shipped'
 END [ShippedDate]
FROM [dbo].[Orders]
WHERE [ShippedDate] is NULL
*/
----1.3
/*SELECT [OrderID] AS [Order Number], 
CASE 
 WHEN [ShippedDate] IS NULL 
 THEN 'Not Shipped'
 END [ShippedDate]
FROM [dbo].[Orders]
WHERE [ShippedDate] > CONVERT(DATETIME, '1998-05-06', 120) OR [ShippedDate] is NULL
*/

--TASK_8.2
----2.1
/*SELECT [ContactName], [Country]
FROM [dbo].[Customers]
WHERE [Country] IN ('USA','Canada')
ORDER BY [ContactName], [Country]
*/
----2.2
/*SELECT [ContactName], [Country]
FROM [dbo].[Customers]
WHERE [Country] IN ('USA','Canada')
ORDER BY [ContactName]
*/
----2.3
/*SELECT DISTINCT [Country]
FROM [dbo].[Customers]
WHERE [Country] IS NOT NULL
ORDER BY [Country]
*/

--TASK_8.3
----3.1
/*SELECT DISTINCT [OrderID]
FROM [dbo].[Order Details]
WHERE [Quantity] BETWEEN 3 AND 10
*/
----3.2
/*SELECT [CustomerID], [Country]
FROM [dbo].[Customers]
WHERE [Country] BETWEEN 'B*' AND 'G*'
ORDER BY [Country]
*/
----3.3
/*SELECT [CustomerID], [Country]
FROM [dbo].[Customers]
WHERE [Country] >= 'B*' AND [Country] <= 'G*'
ORDER BY [Country]
*/

--TASK_8.4
----4.1
/*SELECT [ProductName]
FROM [dbo].[Products]
WHERE [ProductName] like '%cho_olade%'
*/

--TASK_8.5
----5.1
/*SELECT CONVERT(money,ROUND(sum(([UnitPrice]-[UnitPrice]*[Discount])*[Quantity]),2),1) AS [Totals]
FROM [dbo].[Order Details] 
*/
----5.2
/*SELECT COUNT(*) - COUNT([ShippedDate]) AS [Count Orders]
FROM [dbo].[Orders]
*/
----5.3
/*SELECT count(DISTINCT [CustomerID]) AS [Count CustomerID]
FROM [dbo].[Orders]
*/

--TASK_8.6
----6.1
/*SELECT Year([OrderDate]) AS [Year], COUNT([OrderID]) AS [Total]
FROM [dbo].[Orders]
GROUP BY Year([OrderDate])
ORDER BY [Year]

SELECT COUNT(*) as [Total]
FROM [dbo].[Orders]
*/
----6.2
/*SELECT (
	SELECT [LastName]+' '+[FirstName] FROM [dbo].[Employees]
	WHERE [Employees].[EmployeeID] = [Orders].[EmployeeID]
		) AS [Seller]
		, COUNT([OrderID]) AS [Total]
FROM [dbo].[Orders]
GROUP BY [EmployeeID]
ORDER BY [Total]
*/
----6.3 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
/*SELECT
	(SELECT [LastName]+' '+[FirstName] FROM [dbo].[Employees]
	WHERE [Employees].[EmployeeID] = [Orders].[EmployeeID]
		) AS [Seller] 
	,(SELECT [ContactName] FROM [dbo].[Customers]
	WHERE [Customers].[CustomerID] = [Orders].[CustomerID]
		) AS [Customer]
	,COUNT([OrderID]) AS [Amount]
FROM [dbo].[Orders]
WHERE Year([OrderDate]) = 1998
GROUP BY CUBE ([EmployeeID], [CustomerID])
ORDER BY [Amount] DESC
*/
----6.4 
/*SELECT DISTINCT [Customers].[ContactName] AS [Person], 'Customer' AS [Type], [Customers].[City]
FROM [dbo].[Customers], [dbo].[Employees]
WHERE [Customers].[City] = [Employees].[City]
UNION
SELECT DISTINCT [Employees].[LastName]+' '+ [Employees].[FirstName] AS [Person], 'Seller' AS [Type], [Employees].[City]
FROM [dbo].[Customers], [dbo].[Employees]
WHERE [Customers].[City] = [Employees].[City]
ORDER BY [City], [Person]
*/
----6.5
/*SELECT DISTINCT [Cus].[CustomerID], [Cus].[City]
FROM [dbo].[Customers] AS [Cus], [dbo].[Customers] AS [Cus2]
WHERE [Cus].[City] = [Cus2].[City] AND [Cus].[CustomerID] <> [Cus2].[CustomerID]
ORDER BY [City]

SELECT [Customers].[City]
FROM [dbo].[Customers]
GROUP BY [City]
HAVING COUNT([City])>1
ORDER BY [City]
*/
----6.6
/*SELECT DISTINCT [Emp].[LastName] AS [UserName], [Emp2].[LastName] AS [Boss]
FROM [dbo].[Employees] AS [Emp], [dbo].[Employees] AS [Emp2]
WHERE [Emp].[ReportsTo] = [Emp2].[EmployeeID]
*/

--TASK_8.7
----7.1
/*SELECT [Emp].[LastName], [Terr].[TerritoryDescription]
FROM [EmployeeTerritories] AS [EmpTerr] 
	INNER JOIN [Employees] AS [Emp] ON [EmpTerr].EmployeeID = [Emp].[EmployeeID]
	INNER JOIN [Territories] AS [Terr] ON [EmpTerr].[TerritoryID] = [Terr].[TerritoryID]
	INNER JOIN [Region] AS [Reg] ON [Terr].[RegionID] = [Reg].[RegionID] and [Reg].[RegionDescription] = 'Western'
*/

--TASK_8.8
----8.1
/*SELECT [Customers].[ContactName], COUNT([Orders].[OrderID]) AS [CountOrders]
FROM [Customers] LEFT JOIN [Orders] ON [Customers].[CustomerID] = [Orders].[CustomerID]
GROUP BY [Customers].[ContactName]
ORDER BY [CountOrders]
*/

--TASK_8.9
----9.1 = не приминимо, т.к. подзапрос может возвращать несколько значений
/*SELECT [CompanyName]
FROM [Suppliers]
WHERE [SupplierID] IN (
	SELECT [SupplierID]
	FROM [dbo].[Products]
	WHERE [UnitsInStock] = 0
	)
*/

--TASK_8.10
----10.1
/*SELECT [LastName]
FROM [Employees]
WHERE  [EmployeeID] in (
	SELECT DISTINCT [EmployeeID]
	FROM [Orders]
	GROUP BY [EmployeeID]
	HAVING COUNT([OrderID]) > 150
	)
*/

--TASK_8.11
----11.1
/*SELECT [ContactName]
FROM [Customers] AS [COS]
WHERE NOT EXISTS (
	SELECT [CustomerID]
	FROM [Orders]
	WHERE [Orders].[CustomerID] = [COS].[CustomerID]
	)
*/

--TASK_8.12
----12.1
/*SELECT SUBSTRING([LastName],1,1) as [ABC]
FROM [Employees]
ORDER BY [ABC]
*/

--TASK_8.13
----13.1
/*exec [dbo].[GreatestOrders] @TopRec = 10, @Year = 1997;

SELECT [Employees].[FirstName]+' '+[Employees].[LastName] AS [Employee] 
	, [Orders].[OrderID]
	, [Order Details].[UnitPrice]*[Order Details].[Quantity]*(1-[Order Details].[Discount]) AS [OrderCoast]
FROM [Orders] INNER JOIN [Employees] ON [Orders].[EmployeeID] = [Employees].[EmployeeID]
	INNER JOIN [Order Details] ON [Orders].[OrderID] = [Order Details].[OrderID]
WHERE [Employees].[FirstName]='Margaret' and [Employees].[LastName]='Peacock'
ORDER BY [OrderCoast] DESC
*/
----13.2
--exec [dbo].[ShippedOrdersDiff] @ShipDay = 30

----13.3
--PRINT N'This user has SET NOCOUNT turned ON.'
--PRINT N'This user has SET NOCOUNT turned ON.'

--exec [dbo].[SubordinationInfo] @EmplID = 2

/*WITH [DirectReports]([ReportsTo], [EmployeeID], [Title], [EmployeeLevel]) AS   
(  
    SELECT [ReportsTo], [EmployeeID], [FirstName]+' '+[LastName] AS [Title], 0 AS [EmployeeLevel]  
    FROM [dbo].[Employees]
    WHERE [EmployeeID]=2	--[ReportsTo] is null
    UNION ALL  
    SELECT e.[ReportsTo], e.[EmployeeID], e.[FirstName]+' '+e.[LastName] AS [Title], [EmployeeLevel] + 1  
    FROM [dbo].[Employees] AS e  
        INNER JOIN [DirectReports] AS d  
        ON e.[ReportsTo] = d.[EmployeeID]   
)  
SELECT [ReportsTo], [EmployeeID], [Title], [EmployeeLevel]   
FROM [DirectReports]  
*/

----13.4
SELECT [FirstName]+' '+[LastName] AS [NAME], [dbo].[IsBoss]([EmployeeID]) AS [IsBoss]
FROM [dbo].[Employees]