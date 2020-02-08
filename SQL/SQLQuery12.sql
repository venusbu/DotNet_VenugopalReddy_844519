create database AgentDB;

Use AgentDB;
CREATE TABLE Agent
(agtID int not null primary key,
agtName varchar(50)not null,
SSN bigint not null,
Salary float not null,
DepID int not null);
Insert Into Agent Values(1,'jenny',23456,35000.00,1);
insert into Agent values(2,'sunny',34566,35000.00,2);
insert into Agent values(3,'robert',45678,35000.00,3);
insert into Agent values(4,'rober',45678,35000.00,3);

select *from Agent 
update Agent set salary = 30000.00 where agtID = 1;

select * from Agent where salary >30000

select max(salary)[max salary],min(salary)'min salary',avg(salary)'average salary' from Agent;

select AVG(Salary)from Agent

select agtID, agtName,Salary from Agent where salary >(select AVG(Salary)from Agent);

