create database employeeDB;

Use EmployeeDB;
CREATE TABLE Employe
(EmpID int not null primary key,
EmpName varchar(50)not null,
SSN bigint not null,
Salary float not null,
DepID int not null);
Insert Into Employe Values(1,'jenny',23456,35000.00,1);
insert into employe values(2,'sunny',34566,35000.00,2);
insert into employe values(3,'robert',45678,35000.00,3);
insert into employe values(4,'rober',45678,35000.00,3);

select *from employe 

create table department
(deptid int not null,
deptname varchar(30) not null);

insert into department values(1,'admin');
insert into department values(2,'developer');
insert into department values(3,'stores');
insert into department values(4,'marketing');

select * from department;

select *from employe 

update employe set salary = 30000.00 where empid = 1;

update employe set salary = 25000.00 where empid = 2;

select * from employe where salary between 25000 and 30000

select * from employe where salary < 30000

select * from employe where salary >30000

select empid, empname, depid from employe where depid =2;

alter table department 
add description varchar (100);
select * from department;

update department set description = 'this is an admin department' where deptid = 1;
update department set description = 'this is an developer department' where deptid = 2;
update department set description = 'this is an stores department' where deptid = 3;
update department set description = 'this is an marketing department' where deptid = 4;

alter table employe
add constraint fk_depid foreign key(depid) references department(deptid)

alter table employe 
add dob date

select * from employe;

update employe set dob = '10.08.1995';

alter table employe 
add constraint chk_dob check (dob between '01.01.1990' and '12.31.1999');

insert into employe values(5,'don',52587,35000.00,4,'01.01.1991');

select max(salary)[maax salary],min(salary)'min salary',avg(salary)'average salary' from employe;

select depid,sum(salary) 'total salary' from employe 
group by depid;
order By depid;
 
 Select depid,sum(salary) 'total salary' from employe
 group by depid
 having sum(salary)>=50000
 order by depid;

 select top(2) * from employe

 select top(4) with ties salary from employe
 order by salary;

 insert into employe values(6,'john',25981,38250,3,'12/25/1990');

 insert into employe values(7,'johny',25661,39000,3,'12/25/1990');
 
 insert into employe values(8,'deny',23466,39880,4,'12/28/1990');

insert into employe values(9,'sandy',25847,39223,4,'12/19/1990');

insert into employe values(10,'sanny',25877,39003,null,'12/19/1990');

select * from employe;
 
select * from department;

select e.empid,e.empname,e.salary,e.depid,d.deptname from employe as e inner join 
department as d on e.depid=d.deptid;

select * from employe as e right join department as d on e.depid=d.deptid;

select e.empid,e.empname,e.salary,e.depid,d.deptname from employe as e right outer join
 department as d on e.depid=d.deptid;

select e.empid,e.empname,e.salary,e.depid,d.deptname from employe as e left outer join 
department as d on e.depid=d.deptid;

select getdate() as 'current date';

 select empname, datediff(yy,dob,getdate()) as age from employe;
 
 select day(getdate()) as 'day';

 select month(getdate()) as 'month';

 select year(getdate()) as 'year';

 select empname,len(empname) as 'lenght' from employe;

 select upper(empname) as 'uppercase', lower(empname) as'lowercase' from employe;

 select empname, substring(empname,1,5) as 'partname' from employe; 
 
 select empname, substring(empname,1,6) as 'partname' from employe; 

 select empname, substring(empname,2,6) as 'partname' from employe; 

 select substring('good moorning everybody',1,10);

 select substring('good moorning everybody',1,5);

 select substring('good moorning everybody',2,10);

 select replace('good morning','morning','evening') as 'greetings';

select replace('good morning','good','evening') as 'greetings';

 select empid,empname,salary,depid from employe
 where depid=(select deptid from department where deptname='admin')

 select empid,empname,salary,depid from employe
 where depid=(select deptid from department where deptname='marketing')














drop table employe