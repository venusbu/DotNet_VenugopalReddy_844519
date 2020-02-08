Create DataBase EmployeeEFDB;
create Table Employee
(EmpID int Primary Key,
Name varchar(30) not null,
SSN bigint not null,
Salary float not null,
DepID int not null);

select * from Employee;
Create Table Department
(DepID int Primary Key,
Name varchar(30) not null);

Alter Table Employee
Add Constraint FK_DepID FOREIGN KEY(DeptID) references Department(DepID);
select * from Employee

Insert Into Department Values(1,'Admin');
Insert Into Department Values(2,'Marketing');
Insert Into Department Values(3,'Teaching');



Select * from Employee;

Select *  from Department;

Insert into Employee Values (4,'someEmployee',1111,1000,1);
select Top 1000 [ProductID]
[Name],
[Price],
[Quantity],
[CategoryID]