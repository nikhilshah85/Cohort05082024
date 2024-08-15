create table EmployeeInfo
		(
			empNo int,
			empName varchar(20) not null,
			empDesignation varchar(20),
			empEmail varchar(50),
			empSalary int,

			constraint pk_empNo primary key(empNo),
			constraint chk_empName_length check ( len(empName) >= 3)
		)

		insert into EmployeeInfo values(501,'Rick','Developer','rick@somewhere.com',8000)		
		insert into EmployeeInfo values(502,'Sheldon','Designer','sheldon@somewhere.com',18000)		
		insert into EmployeeInfo values(503,'Ammy','Manager','ammy@somewhere.com',9000)		
		insert into EmployeeInfo values(504,'Kayle','Developer','penny@somewhere.com',22000)			   		
		insert into EmployeeInfo values(505,'A','Developer','raj@somewhere.com',8000)
		
		insert into EmployeeInfo(empNo,empDesignation,empEmail,empSalary)
		values
		(506,'Developer','howard@gmail.com',8989)


		alter table EmployeeInfo add constraint chk_empDesignation check (empDesignation in ('Developer','Designer','Manager'))
		insert into EmployeeInfo values(506,'John','Designer','john@somewhere.com',8000)

		--if you execute this statement first, then it will make empEmail as mandatory field
		--if you use do not use below statement and add a unique key to col it will allow 1 time a null value for empEmail
		--alter table EmployeeInfo alter column empEmail varchar(50) not null
		alter table EmployeeInfo add constraint unk_empEmail unique (empEmail)

		insert into EmployeeInfo values(507,'Rickey','Manager','rick@somewhere.com',9000)
		--unique key col will allow 1 null value, but not more than 1
		insert into EmployeeInfo (empNo,empName,empDesignation,empSalary)
		values
		(508,'Emily','Designer',8000)
		select * from EmployeeInfo
		insert into EmployeeInfo (empNo,empName,empDesignation,empSalary)
		values
		(509,'Jennifer','Designer',18000)

		insert into EmployeeInfo (empNo,empName,empDesignation,empSalary)
		values
		(508,'Scott','Developer',19000)

		--delete all the rows where designation is not a designer or developer or manager
		delete from EmployeeInfo where empDesignation not in ('Designer','Developer','Manager')

		delete from EmployeeInfo where empSalary not between 5000 and 25000

	alter table employeeInfo add constraint chk_salaryRange check (empSalary between 5000 and 25000)


		create table deptInfo
		(
			deptNo int,
			deptName varchar(20) not null,
			deptCity varchar(20) not null,

			constraint pk_deptNo primary key(deptNo),
			constraint unk_deptName unique(deptName)		
		)


			insert into deptInfo values(10,'HR','NYK')
			insert into deptInfo values(20,'Sales','New Jersey')
			insert into deptInfo values(30,'Training','Mumbai')	
			insert into deptInfo values(40,'IT','London')

			alter table employeeInfo add empDept int
				select * from EmployeeInfo

			alter table employeeInfo add constraint fk_empDept foreign key(empDept) references deptInfo


			--this will fail
			insert into EmployeeInfo values(510,'Angel','Designer','angel@somewhere.com',8000,50)
		
			--correct
			
			insert into EmployeeInfo values(510,'Angel','Designer','angel@somewhere.com',8000,20)

