Create database EmployeeEFDB

use EmployeeEFDB

create table Employee 

(EmpID int primary key,
Name varchar(30) not null,
SSN bigint not null,
Salary float not null,
DepID int not null);

create Table Department
(Dept int primary key,
Name varchar(30) not null);
SELECT * FROM Employee

Alter Table Employee
Add Constraint Fk_DepID FOREIGN KEY(DepID) references Department(Dept);

Insert into Department values(1,'Admin');
Insert into Department values(2,'Co-admin');
Insert into Department values(3,'manager');

select * from Department;
select * from Employee;

insert into Employee values(4,'someemployee',54749,55000,1);