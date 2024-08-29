create database ProductsDB

use ProductsDB

create table ProductsInfo
(
	pid int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit
)

insert into ProductsInfo values(101,'Pepsi','Cold-Drink',50,1)
insert into ProductsInfo values(102,'Nike Air','Shoes',50,0)
insert into ProductsInfo values(103,'IPhone Pro Max','Smart-Phone',50,1)
insert into ProductsInfo values(104,'Macbook Air','Electronics',50,1)
insert into ProductsInfo values(105,'Jeep Compass','SUV',50,0)
insert into ProductsInfo values(107,'Air-Pods','Electronics',50,1)

select * from ProductsInfo


alter table productsInfo alter column pid int not null
alter table productsInfo add constraint pk_pid primary key(pid)



