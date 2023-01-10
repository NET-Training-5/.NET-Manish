create table Employee
(
	Id int not null identity primary key,
	Name nvarchar(200) not null,
	Address nvarchar(300),
	Gender char(1) not null,
	Dob datetime
)
GO

insert into Employee
values ('Ashesh Shrestha', 'Kathmandu', 'M', '1988/12/12')

select * from Employee;