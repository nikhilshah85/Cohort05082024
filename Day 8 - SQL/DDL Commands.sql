--drop database EmployeeManagementDB
--drop database BankingDB
	--this way you can drop any object
	--eg. drop table EmployeeInfo
		  -- drop procedure CalculateBonus

--------------------------------
create database BankingDB
create database EmployeeManagementDB
create database ShoppingDB

create table AccountsInfo
(
	accNo int,
	accName varchar(20),
	accType varchar(20),
	accBalance bigint,
	accIsActive bit
)

create table BranchInfo
(
	branchNo int,
	branchName varchar(20),
	branchCity varchar(20)
)

--lets say we want to add a new column to Branchinfo, how can we ?
alter table BranchInfo add branchEmail varchar(20)
alter table BranchInfo alter column branchName varchar(50)
alter table BranchInfo drop column branchCity

drop table BranchInfo







