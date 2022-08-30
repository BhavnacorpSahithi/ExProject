use vbforms

     create table Login(Id int primary key,name nvarchar(30) ,email nvarchar(50),password nvarchar(50),mobile numeric(10,0));
    
    select * from Login 

   insert into Login(name ,email,password,mobile) values ('Mahesh','mahesh@gmail.com','mahesh123',54665757)

   delete from Login where Id=6
  

   create table logger(id int primary key ,message nvarchar(30),updatedtime DateTime)

  -- Trigger for insertion of table
  create trigger InsertTrigger
  on Login
  for insert
  as
  begin
  insert into logger select ID,'Record inserted',GETDATE() from inserted
  end

  -------------------------------------
  --deletion for Triggers
  -----------------------------------
  create trigger DeleteTrigger
  on Login
  instead of delete
  as
  begin
  insert into logger select ID,'Record deleted',GETDATE() from deleted
  end



  



