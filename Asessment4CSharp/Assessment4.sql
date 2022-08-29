create database Assessment

use Assessment

create table doctors (
doctors_id int identity primary key,
doctors_name varchar(20),
doctors_age int,
doctors_mobile int,
doctors_gender varchar(20),
specialization varchar(20),
Salary int)

--patients tble
create table patients (
patient_id int identity primary key,
patient_name varchar(20),
age int ,
gender varchar(20),
reg_fee int,
mobile int,
problem varchar(30),
Doj DateTime,
doctors_id int foreign key references doctors(doctors_id),
)

create table bill(
bill_no int identity primary key,
patient_id int foreign key references patients(patient_id),
doctor_charge int,
room_charge int,
no_of_days int,
lab_charge int,
bill int) 

insert into bill(patient_id,doctor_charge,room_charge,no_of_days,lab_charge,bill)
values
(9,2000,1000,35,1500,4500),(10,300,500,40,2000,2800),(11,500,200,30,5000,5700)

select * from bill

create procedure sp_Doctors
(@doctors_name varchar(20),
@doctors_age varchar(20),
@doctors_mobile int,
@doctors_gender varchar(20),
@specialization varchar(20),
@Salary int
)
as
begin
insert into doctors(doctors_name,specialization,doctors_age,doctors_gender,doctors_mobile,Salary) values(@doctors_name,@specialization,@doctors_age,@doctors_gender,@doctors_mobile,@Salary)
end

exec sp_Doctors
@doctors_name='Raki',@specialization='psychologist',@doctors_age=22,
@doctors_gender='male',
@doctors_mobile=5464774,@Salary=300000

select *from doctors


---insert values for patient
alter procedure sp_Patients
(@patient_name varchar(20),
@age varchar(20),
@gender varchar(20),
@reg_fee varchar(50),
@problem  varchar(50),
@mobile int,
@doctors_id int
)
as
begin
insert into patients(patient_name,age,gender,reg_fee,mobile,problem,doctors_id) values(@patient_name,@age,@gender,@reg_fee,@mobile,@problem,@doctors_id)
end

exec sp_Patients
@patient_name='maala',
@age=23,
@gender='female',
@mobile=123456,
@reg_fee=100,
@problem='headache',
@doctors_id='2'

select * from patients