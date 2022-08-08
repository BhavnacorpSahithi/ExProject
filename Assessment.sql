use Bhavnacorp

create table Flights(flightid int,flightname nvarchar(20) primary key,SourceToDestination nvarchar(50),Ticketprice int);
create table Passenger(passengerid int,passengername nvarchar(30) primary key,address nvarchar(50),phonenumber int,age int,gender nvarchar(10));
create table Booking(Bookingid int primary key,Passengername nvarchar(30) Foreign Key REFERENCES Passenger(passengername),Flightname nvarchar(20) Foreign Key REFERENCES Flights(flightname),TotalPrice int);

insert into Flights values(1001,'Indigo','Dubai-chennai',1500),(1002,'Air-India','Delhi-Russia',20000),(1003,'Spacejet','Hyderabad-kerala',3000),(1004,'Trujet','Delhi-korea',15000),(1005,'Vistaara','Dubai-chennai',2500)
insert into Passenger values(101,'vyshnavi','hyd',6757877,50,'female'),(102,'srikanth','hyd',5467566,25,'male'),(103,'naarsimha','delhi',6575767,23,'male'),(104,'rajnikanth','us',656786,40,'male'),(105,'satish','khanpur',9686765,35,'female'),(106,'usha','hyd',126895,65,'female')
insert into Booking values(11,'vyshnavi','Indigo',1500),(12,'naarsimha','Air-India',20000),(13,'rajnikanth','Trujet',15000),(14,'satish','Spacejet',3000),(15,'usha','Vistaara',2500),(16,'vyshnavi','Air-India',20000)

create procedure sp_selectrecords
as 
begin 
  select * from Flights order by flightid
    select * from Passenger order by passengerid
  select * from Booking

end

exec sp_selectrecords

create procedure sp_GroupbyPassenger
as 
begin 
 select Passengername,count(Flightname) from Booking group by Passengername
end

exec sp_Bookingdetails

create procedure sp_GroupbyFlight
as 
begin 
 select Flightname,count(Passengername) from Booking group by Flightname
end

exec sp_GroupbyFlight

create procedure sp_Norepeatpassengers
as 
begin 
 select Passengername,TotalPrice from Booking where TotalPrice between 1500 and 15000
end

exec sp_Norepeatpassengers

create view joiningtablesView
as 
select Passengername,TotalPrice from Booking where Passengername like '%a'

select * from joiningtablesView


create procedure sp_bookingdata
as 
begin 
select b.Passengername,p.address,p.age,p.gender,b.Flightname,b.TotalPrice from Booking as b inner join Passenger as p on b.Passengername = p.passengername
end

exec sp_bookingdata



