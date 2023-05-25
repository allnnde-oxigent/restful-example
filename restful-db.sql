create database oxigent


use oxigent


create table Employer
(
	Id int identity primary key,
	Name varchar(150) not null,
	LastName varchar(150) not null,
	PhoneNumbre varchar(150),
	Email varchar(150),
	BirthDate Datetime not null
)