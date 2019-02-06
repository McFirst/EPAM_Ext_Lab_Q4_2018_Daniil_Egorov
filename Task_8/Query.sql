use [Northwind]
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