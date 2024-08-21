--get the server date ?
select GETDATE()

select DATEPART(MONTH,getdate())

select DATEADD(week,4,getdate())

select dateadd(DAY,60,getdate())

select DATEPART(MINUTE,getdate())


select DATEPART(M,getdate())

select DATENAME(WEEK,getdate())

select case 
	when  DATEPART(M,getdate()) = 1 then 'January'
	when  DATEPART(M,getdate()) = 2 then 'Febuary'
	when  DATEPART(M,getdate()) = 3 then 'March'
	when  DATEPART(M,getdate()) = 4 then 'April'
	when  DATEPART(M,getdate()) = 5 then 'May'
	when  DATEPART(M,getdate()) = 6 then 'June'
	when  DATEPART(M,getdate()) = 7 then 'July'
	when  DATEPART(M,getdate()) = 8 then 'August'
	when  DATEPART(M,getdate()) = 9 then 'September'
	when  DATEPART(M,getdate()) = 10 then 'October'
	when  DATEPART(M,getdate()) = 11 then 'November'
	when  DATEPART(M,getdate()) = 12 then 'December'
	end
	as Month


	-------------------Do now allow insert or update or delete between 00:00 to 01:00  
	--let us create a before trigger, where server will validate the condition before processing
	--the request

	alter trigger trg_before_accountsInfo
	on accountsinfo	
	for insert,update,delete
	as 
	begin
		if(DATEPART(MINUTE,getdate()) between 30 and 60)
		begin
			print 'Sorry Insert not alloed at this time, please try later'
			rollback
		end
	end

	select DATEPART(HOUR,getdate())
	select * from AccountsInfo where accNo = 111

	insert into AccountsInfo values(111,'Someone','Savings',7000,1,20)


	--------------------------------------------------------------------------------------
	--first example lets have a history table
	create table empInfo
	(
		empNo int primary key,
		empName varchar(20),
		empDesignation varchar(20),
		empSalary int,
		empIsPermenant bit
	)

	create table empInfo_history
	(
	    eId int identity,
		action varchar(200),
		actiontime datetime,
		empNo int,
		empName varchar(20),
		empDesignation varchar(20),
		empSalary int,
		empIsPermenant bit
	)
	
	--what ever value is inserted in empInfo table, a copy should be marked in empInfo_history
	alter trigger trg_empInfo
     on empInfo
	 for insert
	as
	begin
			--value which are inserted on empinfo has to go to empInfo_history table
			--there is a special table call inserted in memory
		declare @v_action varchar(200) =' Employee Added'
		declare @v_actiontime datetime = Getdate()
		
		declare @v_empNo int 
		set @v_empNo = (select i.empNo from inserted i)

		declare @v_empName varchar(20)
		set @v_empName = (select i.empName from inserted i)

		declare @v_empDesignation varchar(20)
		set @v_empDesignation = (select i.empDesignation from inserted i)

			declare @v_empSalary int
		set @v_empSalary = (select i.empSalary from inserted i)

	
		declare @v_empIsPermenant bit
		set @v_empIsPermenant = (select i.empIsPermenant from inserted i)


		insert into empInfo_history values(@v_action,@v_actiontime,@v_empNo,@v_empName,@v_empDesignation,@v_empSalary,@v_empIsPermenant)
	end



	select * from empInfo
	select * from empInfo_history


	insert into empInfo values(23,'Jessica','HR',25000,0)


























