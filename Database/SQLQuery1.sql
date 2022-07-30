
-------------------- Ayoub Ahnouche-------------------------

create database GYM_MANAGEMEN_db

on primary (
Name = GYM_MANAGEMEN_db_date,
fileName ='E:\My Web Site\4_c#\GYM MANAGEMENT SYSTEM  C#\Database\GYM_MANAGEMEN_db.mdf',
size = 6mb,
MaxSize=8MB,
FileGrowth=4MB  )

Log on(
name= GYM_MANAGEMEN_db_Log,
filename='E:\My Web Site\4_c#\GYM MANAGEMENT SYSTEM  C#\Database\GYM_MANAGEMEN_db.Ldf',
Size=6MB,
MaxSize=8MB,
FileGrowth=4MB  )


CREATE TABLE [employee](
	[emp_id] int primary key IDENTITY(1,1)  ,
	[emp_username] nvarchar(50) NOT NULL,
	[name] nvarchar(50)NOT NULL,
	[password] nvarchar (50) NOT  NULL,
	[gender] varchar(50) NOT NULL CHECK (gender in('male','female')),
	[email] nvarchar(50)  ,
	[mobile]nvarchar (50) ,
	[address] nvarchar(50) ,
	[date] datetime  
) 

CREATE TABLE [members](
	[m_id] int primary key IDENTITY(1,1)  ,
	[f_name] nvarchar(50) NOT NULL,
	[l_name] nvarchar(50) NOT NULL ,
	[gender]  varchar(50) NOT NULL CHECK (gender in('male','female')),
	[date_birth] datetime,
	[mobile] nvarchar(50) ,
	[email] nvarchar(50) ,
	[join_date] datetime NOT NULL,
	[gym_time] nvarchar(50),
	[address] nvarchar(50),
	[emp_id] int ,
	constraint fk_emp_member foreign key (emp_id) references employee (emp_id)
	on update cascade
    on delete cascade
)

CREATE TABLE [staff](
	[stf_id] int primary key IDENTITY(1,1)  ,
	[f_name] nvarchar(50) NOT NULL ,
	[l_name] nvarchar(50) NOT NULL,
	[gender] varchar(50) NOT NULL CHECK (gender in('male','female')),
	[date_birth] datetime,
	[mobile] nvarchar (50),
	[email]  nvarchar(50) ,
	[join_dat]  datetime NOT NULL,
	[adress]  nvarchar(50) ,
	[job] nvarchar(50) ,
    [emp_id] int ,
	constraint fk_emp_staff foreign key (emp_id) references employee (emp_id)
	on update cascade
    on delete cascade
)
CREATE TABLE [vendor](
	[v_id] int primary key IDENTITY(1,1)  ,
	[f_name] nvarchar(50) NOT NULL ,
	[l_name] nvarchar(50) NOT NULL,
	[mobile]nvarchar (50),
	[email]  nvarchar(50) ,
	[adress]  nvarchar(50) ,
	[company] nvarchar(50) ,

)

CREATE TABLE [equipment](
	[eqp_id] int primary key IDENTITY(1,1)  ,
	[name] nvarchar(50) NOT NULL,
	[description] nvarchar(350) NOT NULL,
	[used] nvarchar(50) NOT NULL,
	[cost] nvarchar(50) NOT NULL ,
	[emp_id] nvarchar (50) ,
	[v_id] int ,
	constraint fk_emp_eq foreign key (emp_id) references employee (emp_id) ,
	constraint fk_v_eq foreign key (v_id) references vendor (v_id)
	on update cascade
    on delete cascade
) 
-------------------- INSSERT EMP-------------------------

INSERT INTO [dbo].[employee]([emp_username] ,[name],[password],[gender] ,[email],[mobile] ,[address],[date])
     VALUES('AYOUB4','AYOUB4','AYOUB4','AYOUB4','AYOUB@gmail.com','0666666666666','sefrou31000',02/02/2020)

