
use Northwind;
Create Procedure GetCustomersByCountry
(@country varchar (30))
As
Select CustomerID,ContactName,CompanyName,Address,Country from Customers Where Country = @country;
Go
Execute GetCustomersByCountry 'UK';

Create Procedure GetProductsByCategoryID
(@categoryID varchar(30))
As
Select ProductID,ProductName,UnitPrice,p.QuantityPerUnit,c.CategoryID,CategoryName from products p INNER JOIN 
Categories c ON p.CategoryID = c.CategoryID AND c.categoryID = @categoryID;
Execute GetProductsByCategoryID '3';

Declare @country as varchar(30);
set @country = 'France';
Select * from Customers Where country = @country;

Alter Procedure GetTotalOrdersByDates
(@date1 date, @date2 date, @countOrder int output)
As
Select
 @countOrder = Count(OrderId) from Orders Where OrderDate Between @date1 AND @date2;
 Go
 Declare @count as int;
 Declare @date1 as date, @date2 as date;
 Set @date1 = '01/01/1990';
 Set @date2 = '12/31/1998';
 Execute GetTotalOrdersByDates @date1,@date2 , @count output;
 print 'Total number of orders placed:' + Convert(varchar(10),@count );
 Print GetDate();
 Select * from Orders

 Create function Multiply (@n1 int , @n2 int)
 Returns bigint
 As
 Begin
 Declare @prod as bigint;
 Set @prod = @n1*@n2;
 Return @prod;
 End
 
 Select dbo.Multiply(50,80) as Product ;

 Create function GetCustomer(@country varchar(30)) returns table
 as
 return select * from Customers Where Country=@country;
 go

 select * from dbo.GetCustomer('Germany');
alter function GetAllProductsByCategoryID(@categoryID int) Returns Table
 As
 Return Select p.ProductID, p.ProductName,p.UnitPrice,p.QuantityPerUnit,c.CategoryID,c.CategoryName 
 from Products p INNER JOIN Categories c on p.CategoryID=c.CategoryID AND c.categoryID = @categoryID;

 select * from dbo.GetAllProductsByCategoryID(5);


 Select ProductID, ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products
 Where UnitPrice > (select AVG (UnitPrice) from Products) Order By UnitPrice

 Select OrderID, CustomerID, EmployeeID, OrderDate, ShippedDate 
 from Orders Where OrderID = (Select OrderID from  Orders Where EmployeeID = 3 AND CustomerID = 'VINET');

 Select CustomerID,CompanyName, Address,Country from Customers 
 Where EXISTS (Select ContactName,Country from Customers Where Country IN ('UK','VENU'));