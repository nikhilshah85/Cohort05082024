create database P0_Nikhil_bankingDB

use P0_Nikhil_bankingDB

use BankingDB

create table AdminUser
(
	userName varchar(20),
	password varchar(20)

	constraint pk_userName_admin primary key(userName)
)

insert into AdminUser values('AdminA','a_admin_2314')
insert into AdminUser values('AdminB','b_admin_2324')
insert into AdminUser values('AdminC','c_admin_2334')
insert into AdminUser values('AdminD','d_admin_2344')

create table CustomerUser
(
	userName varchar(20),
	password varchar(20)

	constraint pk_userName_customer primary key(userName)
)

insert into CustomerUser values('Nikhil','nik_1236!')
	insert into CustomerUser values('Rick','rick_1236!')
	insert into CustomerUser values('Donald','donald_1236!')
	insert into CustomerUser values('Bill','bill_1236!')
	insert into CustomerUser values('Georg','george_1236!')

create table AccountInfo
(
	accNo int,
	accName varchar(20),
	accType varchar(20),
	accBalance int,
	accIsActive bit,
	accCustomer varchar(20),

	constraint pk_accNo primary key(accNo),
	constraint fk_accCustomer foreign key(accCustomer) references CustomerUser
	)

insert into AccountInfo values(501,'Nikhil Shah','Savings',7000,1,'Nikhil')
insert into AccountInfo values(502,'Rick Dorsan','Loan',8000,1,'Rick')
insert into AccountInfo values(503,'Donald Trump','Savings',17000,0,'Donal')
insert into AccountInfo values(504,'Bill Clinton','Checking',27000,1,'Bill')
insert into AccountInfo values(505,'George Bush','Savings',37000,0,'Georg')


create table NewServiceRequest
(
	requestId int identity, --identity is auto generated values, you do not need to insert
						    --it will be ,1, 2,3, 4, 5, 6,etc....
	accNo int, --which account is making this request
	requestDescription varchar(200)

	constraint pk_requestId primary key(requestId),
	constraint fk_accNo foreign key(accNo) references accountinfo
)

















