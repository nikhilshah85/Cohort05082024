create table branchInfo
(
	branchNo int,
	branchName varchar(20) not null,
	branchCity varchar(20) not null,

	constraint unk_branchName unique(branchName),
	constraint pk_branchNo primary key(branchNo)
)

insert into branchInfo values(10,'Sersi','Hong Kong')
insert into branchInfo values(20,'Elephie','Makati City')
insert into branchInfo values(30,'Band Stand','Mumbai')
insert into branchInfo values(40,'East Cost','Singapore')
insert into branchInfo values(50,'Patong','Phuket')

select * from branchInfo

create table AccountsInfo
(
	accNo int,
	accName varchar(20) not null,
	accType varchar(20),
	accBalance int,
	accIsActive bit,
	accBranchNo int,
	constraint pk_accNo primary key(accNo),
	constraint fk_accBranchNo foreign key(accBranchNo) references branchInfo
)


insert into AccountsInfo values(1,'Nikhil','Savings',6000,1,10)
insert into AccountsInfo values(2,'Stephney','Loan',12000,0,20)
insert into AccountsInfo values(3,'Sheldon','Checking',10000,1,30)
insert into AccountsInfo values(4,'Howard','Savings',16000,1,20)
insert into AccountsInfo values(5,'Penny','Savings',13000,0,10)
insert into AccountsInfo values(6,'Stuart','Checking',12000,1,10)
insert into AccountsInfo values(7,'Raj','Savings',6000,1,20)
insert into AccountsInfo values(8,'Ammy','Savings',7000,0,30)
insert into AccountsInfo values(9,'Kevin','Savings',8000,1,20)
insert into AccountsInfo values(10,'Will','Checking',9000,1,30)
insert into AccountsInfo values(11,'Leonard','Savings',13000,1,20)
insert into AccountsInfo values(12,'Bernadette','Savings',15000,1,10)
insert into AccountsInfo values(13,'Priya','Checking',21000,1,20)
insert into AccountsInfo values(14,'Micheal','Savings',22000,0,20)
insert into AccountsInfo values(15,'Rodrique','Loan',24000,0,10)

insert into AccountsInfo values(16,'Monica','Savings',21000,0,null)
insert into AccountsInfo values(17,'Ross','Loan',24000,0,null)
insert into AccountsInfo values(18,'Joey','Loan',24000,0,null)



select * from AccountsInfo

select * from AccountsInfo join branchInfo
		on AccountsInfo.accBranchNo = branchInfo.branchNo



select AccountsInfo.accNo, AccountsInfo.accName, branchInfo.branchNo, branchInfo.branchName,branchInfo.branchCity
		from AccountsInfo join branchInfo
		on
		AccountsInfo.accBranchNo = branchInfo.branchNo

--------------------------------
--Left Join


select AccountsInfo.accNo,
	   AccountsInfo.accName, 
	   branchInfo.branchNo, 
	   branchInfo.branchName,
	   branchInfo.branchCity
		from AccountsInfo left join branchInfo
		on
		AccountsInfo.accBranchNo = branchInfo.branchNo

-------------------------------
--right join



select AccountsInfo.accNo,
	   AccountsInfo.accName, 
	   branchInfo.branchNo, 
	   branchInfo.branchName,
	   branchInfo.branchCity
		from AccountsInfo right join branchInfo
		on
		AccountsInfo.accBranchNo = branchInfo.branchNo


---------
--Full Join


select AccountsInfo.accNo, AccountsInfo.accName, branchInfo.branchNo, branchInfo.branchName,branchInfo.branchCity
		from AccountsInfo full join branchInfo
		on
		AccountsInfo.accBranchNo = branchInfo.branchNo

----------
--Null Join


select AccountsInfo.accNo, AccountsInfo.accName, branchInfo.branchNo, branchInfo.branchName,branchInfo.branchCity
		from AccountsInfo full join branchInfo
		on
		AccountsInfo.accBranchNo = branchInfo.branchNo
		where AccountsInfo.accBranchNo is null

		select * from AccountsInfo,branchInfo
			--accounts table 18
			--branch table 5 
			--18 * 5 = 90 rows

















