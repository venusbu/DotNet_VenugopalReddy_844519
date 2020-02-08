create database EmployeeAB;
use EmployeeAB;
create table Employee
(empid int not null primary key,
emname varchar(50) not null,
ssn bigint not null,
salary float not null,
deptid int not null);
insert into Employee values(1,'suresh',0001,12000,1);
insert into Employee values(2,'vicky',0002,22000,2);
insert into Employee values(3,'ricky',0003,32000,3);
insert into Employee values(4,'rocky',0004,42000,7);
select * from Employee

create table department
(deptid int not null primary key,
deptname varchar(50) not null);
insert into department values(1,'Admin');
insert into department values(2,'marketing');
insert into department values(3,'technical');
insert into department values(4,'stores');
select * from department;

alter table department
add descriptio varchar(100);
update department set descriptio='this is admin area' where deptid=1;
update department set descriptio='this is marketing area' where deptid=2;
update department set descriptio='this is technical area' where deptid=3;
update department set descriptio='this is stores area' where deptid=4;


alter table Employee
Add dob date;
update Employee set dob='10/12/1997' where empid =1;
update Employee set dob='12/11/1995' where empid =2;
update Employee set dob='10/05/1992' where empid =3;
update Employee set dob='12/31/1996' where empid =4;
select deptid, sum(salary) [total salary] from Employee group by(deptid)having sum(salary)>25000 order by deptid;
select top(5) * from Employee order by salary;

select e.empid,e.emname,e.ssn,e.salary,d.deptid,d.deptname from Employee as e inner join department as d on e.deptid =d.deptid
Select GetDate() as 'Current Date';
DateDiff() function
Select EmName, DateDiff(YY,DOB,GetDate()) as Age from Employee;
Select Day(Getdate()) as 'day';
select month(getdate()) as 'month';
select year(getdate()) as 'year';

string functions
select emname, len(emname) as 'length'from employee;
select upper (emname) as 'uppercase', lower(emname) as 'lowercase' from employee;
select emname, substring (emname,1,5) as 'partname' from employee;
these functions can also be used individually by passing data arguments
select substring('good morning everybody',1,10);
select emname, reverse(emname) as 'name reversed' from employee;
select replace('good morning', 'morning', 'evening') as 'greetings';
sUB QUIRES
SELECT EMPID,EMNAME,SALARY FROM EMPLOYEE WHERE SALARY > (SELECT AVG(SALARY) FROM EMPLOYEE);
WRITING SUB QUERY FROM ANOTHER TABLE
SELECT EMPID,EMNAME,SALARY,DEPTID FROM EMPLOYEE WHERE DEPTID = (SELECT DEPTID FROM DEPARTMENT WHERE DEPTNAME = 'TECHNICAL');

SELECT EMPID,EMNAME,SALARY,DEPTID FROM EMPLOYEE WHERE DEPTID = (SELECT DEPTID FROM DEPARTMENT WHERE DEPTNAME = 'ADMIN');