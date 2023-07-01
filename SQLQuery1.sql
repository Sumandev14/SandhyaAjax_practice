use Sandhya_380Test;

select * from Users;

create table studentTable
(
studentId int primary key identity(1,1),
UserName  varchar(50),
Email varchar(250),
Password varchar(50),
Mobile bigint,
Gender varchar(50),
Subject varchar(250),
Address varchar(250),
Role int,
IsDelete bit DEFAULT 1,
);

insert into studentTable (UserName, Email, Password, Mobile, Gender, Subject, Address, Role)
values('david', 'david@example.com', 'david123', 1234567890, 'Male', 'Mathematics Physics', '123 gfh St', 2);
select * from studentTable;

 


