create function greetings() returns varchar(20)
as
begin
	--//business logic
	return 'Hello and welcome to TSQL Functions '
end


alter function greetings() returns varchar(80)
as
begin
	--//business logic
	return 'Hello and welcome to TSQL Functions '
end
select dbo.greetings() as Message

--begin is equal to {
--end is equal to}
----------------------------------------------------------------------------

create function AddNumbers(@num1 int, @num2 int) 
returns int
as
begin
	declare @addResult int;
	set @addResult = @num1 + @num2
	return @addResult
end


select dbo.AddNumbers(30,40) as Addition

-------------------------------------------------------------------------------------
create function Calculate(@num1 int, @num2 int, @operation varchar(1))
returns int
as
begin
	
	if(@operation = '+')
	begin
		return (@num1 + @num2)
	end
	if(@operation = '-')
	begin
		return (@num1 - @num2)
	end
	if(@operation = '/')
	begin
		return (@num1 / @num2)
	end
	if(@operation = '*')
	begin
		return (@num1 * @num2)
	end
	return 0
end
select dbo.calculate(30,40,'*') as Result


create function NewGreetings(@name varchar(40))
returns varchar(200)
as
begin
	return concat('Hello ',@name,' Welcome to TSQL World',' Hope you will enjoy this')
end

select dbo.NewGreetings('Yash')
select dbo.NewGreetings(accName) as Greet from AccountsInfo 


----------------------------------------------------------------------------------------

create procedure AddNewAccount
(
	@aNo int,
	@name varchar(20),
	@type varchar(20),
	@balance int,
	@isactive bit,
	@branchno int
)
as
begin
	insert into AccountsInfo values(@aNo,@name,@type,@balance,@isactive,@branchno)
end


execute AddNewAccount 999,'Penny','Savings',9000,0,20
select * from AccountsInfo

create procedure deleteAccount(@accNo int)
as
begin
	delete from AccountsInfo where accNo = @accNo
end

exec deleteAccount 40

create procedure updateAccounts(@accNo int)
as
begin
	update AccountsInfo set accBalance = accBalance + 400 where accNo = @accNo
end

exec updateAccounts 50

--------------------------------------------------------------------------------------------

alter procedure proc_AccountsInfo
(
	@action varchar(10),
	@aNo int = 0,
	@name varchar(20) = '',
	@type varchar(20) = '',
	@balance int = 0,
	@isactive bit = true,
	@branchno int = 10
)
as
begin
	if(@action = 'Add')
	begin
			insert into AccountsInfo values(@aNo,@name,@type,@balance,@isactive,@branchno)
	end
	else if(@action = 'Update')
	begin
			update AccountsInfo set accBalance = accBalance + 5000 where accNo = @aNo 
	end
	else if (@action = 'UpdateSpecificBalance')
	begin
		update AccountsInfo set accBalance = @balance where accNo = @aNo 
	end
	else if(@action = 'Delete')
	begin
		delete from AccountsInfo where accNo = @aNo
	end
	else if(@action = 'SearchByAccType')
	begin
		select * from AccountsInfo where accType = @type
	end
	else if(@action = 'SearchByAccNo')
	begin
		select * from AccountsInfo where accNo = @aNo
	end

end

exec proc_AccountsInfo 'UpdateSpecificBalance',6,'','',78000,0,30

select * from AccountsInfo

select * from AccountsInfo where accNo = 3












































