use Northwind;

Create Procedure GetCustomersByCountry
(@country varchar(30))
As
Select CustomerID,ContactName,CompanyName,Address,Country from Customers where Country = @country;
Go

Execute GetCustomersByCountry 'USA';

create Procedure GetProductsByCategoryID
(@categoryID int)
As
Select p.ProductID, p.ProductName, p.UnitPrice, p.QuantityPerUnit, c.CategoryID, c.categoryName from Products p
 INNER JOIN Categories c ON p.CategoryID = c.CategoryID AND c.CategoryID = @categoryID;

Execute GetProductsByCategoryID '5'; 

---Declaring local variables

Declare @country as varchar(30);
Set @country = 'France';
Select * from Customers where Country = @country;

Alter Procedure GetTotalOrdersByDates
(@date1 date, @date2 date, @countOrder int output)
As 
select @countOrder = count(OrderID) from Orders where OrderDate between @date1 And @date2;
Go

Declare @count as int;
declare @date1 as date, @date2 as  date;

set @date1 = '01/01/1990';
set @date2 = '12/31/1998';

Execute GetTotalOrdersByDates @date1,@date2,@count output;

print 'Total number of orders placed:' + convert(varchar(10),@count);

print Getdate();

select * from Orders;

---creating functions

 ---by default this function is stored inside the default schema known as 'dbo' which stands for database owner
create function Multiply(@n1 int, @n2 int) Returns bigint
As 
Begin
Declare @prod as bigint;
Set @prod = @n1*@n2;
Return @prod;
End

select dbo.Multiply(50,80) as Product;

---table valued function
create function GetCustomers(@country varchar(30)) Returns Table
As
return select * from Customers where Country = @country;
Go

select * from dbo.GetCustomers('germany');


create function GetAllProductsByCategoryID(@categoryID int)Returns Table
As
Return Select p.ProductID, p.ProductName, p.UnitPrice, p.QuantityPerUnit, c.CategoryID, c.categoryName from
 Products p INNER JOIN Categories c ON p.CategoryID = c.CategoryID AND c.CategoryID = @categoryID;

select * from dbo.GetAllProductsByCategoryID(5);

---subqueries
--1. A subquery is used as a part of a main query, and the values returned from the subquery will be used by the main query for its execution

--2. sometimes a subquery is used in-place of JOIN operations to combine two tables,but Joins are preffered over subqueries because of their effiency

Select ProductID, ProductName, UnitPrice, QuantityPerUnit, CategoryID from Products 
where UnitPrice > (Select AVG(UnitPrice)from Products) Order By UnitPrice;

select * from Orders;

select OrderID, CustomerID,EmployeeID,OrderDate,shippedDate from Orders where 
OrderID = (select OrderID from Orders where EmployeeID = 5 AND CustomerID = 'VINET');

---correalated subqueries

--A correlated subquery doesn't return any data back to the main query.But it always returns a boolean value of either 'true' or 'false' and accordingly the main query gets executed if it recieves a boolean value of true. Otherwise the main query willnot be executed.

--These correlated subqueries make use of EXISTS or NOT EXISTS operators as a part of main query.

select CustomerID, CompanyName, Address, Country from Customers where EXISTS (select ContactName from Customers where Country in('Uk' , 'USA'));

select CustomerID, CompanyName, Address, Country from Customers where NOT EXISTS (select ContactName from Customers where Country = 'Russia');
  