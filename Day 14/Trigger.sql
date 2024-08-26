select * from AccountsInfo
select * from branchInfo

create view newAccounts
as
select a.accNo as Number,
	  a.accName as Name,
	a.accType as [Account Type],
	a.accBalance as [Available Balance],
	b.branchNo as [Branch],
	b.branchName as Location,
	b.branchCity as City
from AccountsInfo a join branchInfo b
	on a.accBranchNo = b.branchNo

	select * from newAccounts

	insert into newAccounts values(2100,'Mary','Savings',9000,30,'Empire State','NYK')


	alter trigger trg_newAccount
	on newAccounts
	instead of insert
	as
	begin
		declare @no int
		set @no = (select i.Number from inserted i)

		declare @name varchar(20)
		set @name = (select i.Name from inserted i)
		
		declare @acctype varchar(20)
		set @acctype = (select i.[Account Type] from inserted i)

		declare @bal int
		set @bal = (select i.[Available Balance] from inserted i)

		declare @brNo int
		set @brNo = (select i.Branch from inserted i)

	--	insert into AccountsInfo values(@no,@name,@acctype,@bal,0,@brNo)

		insert into AccountsInfo(accno,accname,accType,accBalance,accBranchNo)
			values(@no,@name,@acctype,@bal,@brNo)


			   		 	
	end

		insert into newAccounts values(4141,'Alex','PF',3400,20,'Empire State','NYK')

		select * from accountsInfo where accNo = 4141

		create trigger trg_deletenewAccounts
		on newAccounts
		instead of delete
		as
		begin
			declare @no int
			set @no  = (select d.Number from deleted d)

			delete from AccountsInfo where accNo = @no
			delete from transactionInfo where accNo = @no

			--insert into logdetailstable values(@no,getdate(),@@IDENTITY,..)
			--delete
			--update
		end

		delete from newAccounts where number = 4141
		select * from AccountsInfo


		update newAccounts set [Available Balance] = [Available Balance] + 300 where Number =8
		select * from AccountsInfo where accNo = 8

		create trigger trg_updatenewAccounts
		on newAccounts
		instead of update
		as
		begin
		--in case of instead of insert trigger, but this is update not insert
			--declare @bal int
			--set @bal = (select i.[Available Balance] from inserted i)

		--in case of instead of delete trigger, but this is update not delete
			--declare @bal int
			--set @bal = (select d.[Available Balance] from deleted d) 

		--in case of instead of update trigger, you do not have updated u
			declare @bal int
			set @bal = (select i.[Available Balance] from inserted i)



		end
















 



