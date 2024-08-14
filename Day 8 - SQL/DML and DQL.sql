insert into AccountsInfo values(101,'Nikkie','Savings',5000,1)
insert into AccountsInfo values(102,'Ashwin','Checking',15000,1)
insert into AccountsInfo values(103,'Mary','Savings',25000,0)
insert into AccountsInfo values(104,'Stephen','Savings',15000,1)
insert into AccountsInfo values(105,'Jacqline','Checking',35000,1)
insert into AccountsInfo values(106,'Henry','Savings',15000,1)
insert into AccountsInfo values(107,'Micheal','Savings',65000,0)
insert into AccountsInfo values(108,'Adam','Loan',45000,1)
insert into AccountsInfo values(109,'Steve','Savings',35000,0)
insert into AccountsInfo values(110,'Rob','Savings',65000,1)
insert into AccountsInfo values(111,'Stark','Loan',85000,0)

insert into AccountsInfo 
values
(112,'Ned','Loan',15000,0),
(113,'Sansa','Loan',35000,2),
(114,'Dyneryes','Savings',15000,0),
(115,'Joffrey','Loan',25000,0)





select * from AccountsInfo

update AccountsInfo set accName = 'Jon Snow', accBalance = 25000 where accNo = 106
update AccountsInfo set accBalance = accBalance + 500
update AccountsInfo set accBalance = 10000 where accName = 'Jacqline'
update AccountsInfo set accIsActive = 1 where accNo = 103

delete from AccountsInfo -- this will delete everything
delete from AccountsInfo where accNo = 110
select * from AccountsInfo order by accName 
select * from AccountsInfo order by accIsActive, accName

select * from AccountsInfo order by accBalance
select * from AccountsInfo order by accBalance desc


select min(accBalance) from AccountsInfo
select max(accBalance) from AccountsInfo
select avg(accBalance) from AccountsInfo
select SUM(accBalance) from AccountsInfo
select count(accNo) from AccountsInfo

--use it with where clause
select count(accNo) from AccountsInfo where accIsActive = 1
select count(accNo) from AccountsInfo where accType = 'Savings' 
select count(accNo) from AccountsInfo where accType = 'Savings' and accIsActive = 1

select * from AccountsInfo

--you will need to write seperate query for every accType, if you have 50 types then 50 q
select count(accType) from AccountsInfo where accType = 'Savings'

select count(accType) from AccountsInfo where accType = 'Checking'

select count(accType) from AccountsInfo where accType = 'Loan'

select accType, count(accType) from accountsInfo 
			group by accType



			select distinct accType from accountsInfo

			--

select UPPER(accName) from AccountsInfo
select LOWER(accName) from AccountsInfo
select CONCAT(accName,' Has a ',accType,' Account with Bank')  from AccountsInfo
select SUBSTRING(accName,1,3) from AccountsInfo

select * from AccountsInfo where accName like 'S%'
select * from AccountsInfo where accName like '_a%'
select * from AccountsInfo where accName like '%k'



select accNo as AccountNumber, 
		accName as Name, accType as TypeOfAccount 
from AccountsInfo


select accNo as [Account Number], 
		accName as Name, accType as [Type Of Account]
from AccountsInfo

select count(accNo) as 'Total Accounts' from AccountsInfo



































select accNo, accName from AccountsInfo
















