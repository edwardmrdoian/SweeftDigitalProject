create table Pupil 
(
	FirstName varchar(50) not null,
	LastName varchar(50) not null,
	Gender char(1) not null,
	Class int not null,
	SubjectId int not null 
)

create table Teacher 
(
	Id int primary key not null,
	FirstName varchar(50) not null,
	LastName varchar(50) not null,
	Gender char(1),
	Subject varchar(50) not null
)

insert into dbo.Teacher(Id,FirstName,LastName,Gender,Subject)
values(1,'Archil','Ugulava','M','Geography');

insert into dbo.Teacher(Id,FirstName,LastName,Gender,Subject)
values(2,'Jemal','Rogava','M','Math');

insert into dbo.Teacher(Id,FirstName,LastName,Gender,Subject)
values(3,'Maka','Giorgadze','F','History');

insert into dbo.Teacher(Id,FirstName,LastName,Gender,Subject)
values(4,'Guram','Natenashvili','M','Physics');

insert into dbo.Teacher(Id,FirstName,LastName,Gender,Subject)
values(5,'Nino','Nozadze','F','Biology');

insert into dbo.Pupil
(FirstName,LastName,Gender,Class,SubjectId)
values ('Giorgi','Chaganava','M',11,1);

insert into dbo.Pupil
(FirstName,LastName,Gender,Class,SubjectId)
values ('Giorgi','Chaganava','M',11,5);

insert into dbo.Pupil
(FirstName,LastName,Gender,Class,SubjectId)
values ('Ruska','Rusitashvili','F',11,1);

insert into dbo.Pupil
(FirstName,LastName,Gender,Class,SubjectId)
values ('Ruska','Rusitashvili','F',11,3);

insert into dbo.Pupil
(FirstName,LastName,Gender,Class,SubjectId)
values ('Amiran','Melia','M',10,4);

insert into dbo.Pupil
(FirstName,LastName,Gender,Class,SubjectId)
values ('Vaja','Mjavia','M',9,4);

insert into dbo.Pupil
(FirstName,LastName,Gender,Class,SubjectId)
values ('Anzor','Metreveli','M',10,2);

insert into dbo.Pupil
(FirstName,LastName,Gender,Class,SubjectId)
values ('Nukri','Guridze','M',8,2);

insert into dbo.Pupil
(FirstName,LastName,Gender,Class,SubjectId)
values ('Ana','Goginava','F',12,1);

select  T.*
from Pupil p
inner join Teacher T on p.SubjectId=T.Id 
where p.FirstName='Giorgi';