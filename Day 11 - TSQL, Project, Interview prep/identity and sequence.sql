
create table TransactionInfo
(
	trNo int identity,
	trFromAcc int,
	trToAccount int,
	trAmount int
)

drop table TransactionInfo


insert into TransactionInfo values(400,600,12000)


--CreditCardTransactionInfo and ATMTransactionInfo

create table TransactionInfo
(
	trNo int identity(2100,5), --start the auto no from 2100 and increase next value by 5
	trFromAcc int,
	trToAccount int,
	trAmount int
)

insert into TransactionInfo values(400,600,12000)
insert into TransactionInfo values(400,600,12000)
insert into TransactionInfo values(400,600,12000)
insert into TransactionInfo values(400,600,12000)

insert into TransactionInfo values(400,600000000000000000000000,12000) --someone makes a mistake
select * from TransactionInfo

--with identity, below are the problems
--1. if there is an error during execution during insert, identity value wil increase in background
	--and you will miss that value from table, example above
--2. identity is connected only to 1 table, this days I wish to use it accross tables
	--eg. CreditCardTransactionInfo and ATMTransactionInfo, and many other tables
	--we want to share a sequence between them 

		--thus to solve this microsft introduced sequence concept in sql server 2014


create table CreditCardTransactionInfo
(
	trNo int,
	trFromAcc int,
	trToAccount int,
	trAmount int
)
create table ATMTransactionInfo
(
	trNo int,
	trFromAcc int,
	trToAccount int,
	trAmount int
)

--sequence is an object, thus let us create it first
create sequence auto_transactionNo
as int
start with 700
increment by 1

select next value for auto_transactionNo
insert into ATMTransactionInfo values(next value for auto_transactionNo,400,700,12000)

select * from ATMTransactionInfo














select * from TransactionInfo