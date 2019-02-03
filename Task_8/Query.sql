--TASK_8.1
----1.1
/*SELECT [OrderID], [ShippedDate], [ShipVia]
FROM [Northwind].[dbo].[Orders]
WHERE [ShippedDate] >= CONVERT(DATETIME, '1998-05-06', 120) AND [ShipVia] >= 2
*/
----1.2
/*SELECT [OrderID], 
CASE 
 WHEN [ShippedDate] IS NULL 
 THEN 'Not Shipped'
 END [ShippedDate]
FROM [Northwind].[dbo].[Orders]
WHERE [ShippedDate] is NULL
*/
----1.3
/*SELECT [OrderID] AS [Order Number], 
CASE 
 WHEN [ShippedDate] IS NULL 
 THEN 'Not Shipped'
 END [ShippedDate]
FROM [Northwind].[dbo].[Orders]
WHERE [ShippedDate] > CONVERT(DATETIME, '1998-05-06', 120) OR [ShippedDate] is NULL
*/

--TASK_8.2
----2.1
/*SELECT [ContactName], [Country]
FROM [Northwind].[dbo].[Customers]
WHERE [Country] IN ('USA','Canada')
ORDER BY [ContactName], [Country]
*/
----2.2
/*SELECT [ContactName], [Country]
FROM [Northwind].[dbo].[Customers]
WHERE [Country] IN ('USA','Canada')
ORDER BY [ContactName]
*/
----2.3
/*SELECT DISTINCT [Country]
FROM [Northwind].[dbo].[Customers]
WHERE [Country] IS NOT NULL
ORDER BY [Country]
*/

--TASK_8.3
----3.1
/*SELECT DISTINCT [OrderID]
FROM [Northwind].[dbo].[Order Details]
WHERE [Quantity] BETWEEN 3 AND 10
*/
----3.2
/*SELECT [CustomerID], [Country]
FROM [Northwind].[dbo].[Customers]
WHERE [Country] BETWEEN 'B*' AND 'G*'
ORDER BY [Country]
*/
----3.3
/*SELECT [CustomerID], [Country]
FROM [Northwind].[dbo].[Customers]
WHERE [Country] >= 'B*' AND [Country] <= 'G*'
ORDER BY [Country]
*/

--TASK_8.4
----4.1
/*SELECT [ProductName]
FROM [Northwind].[dbo].[Products]
WHERE [ProductName] like '%cho_olade%'
*/

--TASK_8.5
----5.1
/*SELECT CONVERT(money,ROUND(sum(([UnitPrice]-[UnitPrice]*[Discount])*[Quantity]),2),1) AS [Totals]
FROM [Northwind].[dbo].[Order Details] 
*/
----5.2
/*SELECT COUNT(*) - COUNT([ShippedDate]) AS [Count Orders]
FROM [Northwind].[dbo].[Orders]
*/
----5.3
/*SELECT count(DISTINCT [CustomerID]) AS [Count CustomerID]
FROM [Northwind].[dbo].[Orders]
*/

--TASK_8.6
----6.1
SELECT 
FROM [Northwind].[dbo].[Orders]