use BankingDB

select * from AccountsInfo

create view AccountDetails
as
select * from AccountsInfo

select * from AccountDetails

create view SavingsAccount
as
select * from AccountsInfo where accType = 'Savings'


create view UnfitAccounts
as
select * from AccountsInfo where accBalance < 2000

select * from UnfitAccounts  --this is given to an analysy or backend team

--we can also write case statement in sql 


select * from AccountsInfo


create view AccountRatings
as
select accNo as [Account Number],
	   accType as [Account Type],
	   accBalance as [Available Balance],
	   case  
		when accBalance between 5000 and 10000  then '*'
		when accBalance between 10000 and 15000  then '**'
		when accBalance between 15000 and 20000  then '***'
		when accBalance between 20000 and 25000  then '****'
		when accBalance between 25000 and 35000  then '*****'
		else 'NA'
		end 
		as [Ratings]
	from AccountsInfo


select * from AccountsInfo

update AccountsInfo set accBalance = null where accNo = 18




select * from AccountRatings


---very common interview question
---what is a virtual table ??? - a View
--is it physically storing the data ?? - No, comes at runtime, when you execute
--in the background, the query gets executed and table is contacted to get the data

--can you insert or update or delete on a view ???
--Answer 
--yes, when  view is based on a single table (not useing joins)


update AccountRatings set [Available Balance] = 40000 where [Account Number] = 17
delete from AccountRatings where [Account Number] = 19
--insert will not work here because, view is not covering all the columns from accountInfo table

--it will not work on join queries

--still programatically is there way to perform insert, update and delete even for join query for a view
--Yes, we use triggers for the same 



--triggers are of 3 types
--1. before trigger (created on a table)
--2. After trigger (created on a table)
--3. Instead of trigger (special trigger for views based on multiple tables, joins)




select * from AccountsInfo where accNo = 17



















