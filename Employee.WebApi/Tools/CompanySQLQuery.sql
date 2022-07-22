use CompanyDb;

insert into Position(Name)
values('Director'),
('Project Manager'),
('Team Lead'),
('Junior .Net Developer'),
('Middle .Net Developer'),
('Senior .Net Developer');

insert into Company(Name,Brand,MounthlyBudget,RegistrationDate)
values
('DataArt','DataArt',10000, '2021.04.15'),
('Global Logic','Global Logic',100000, '2022.05.23'),
('Nix','Nix',100000, '2021.01.10'),
('Epam','Epam',100000, '2022.04.9'),
('Vector','Vector',9000, '2022.08.21');

insert into Employee(Mail,Name,Surname,Salary,EmploymentDate,DismissDate,PositionId,CompanyId)
values
('ivan.veliky@gmail.com','Ivan','Veliky',35000,'2018.04.18',null, 
(select Id from Position where Name like 'Director'),
(select Id from Company where Name like 'Global Logic')),

('mariia.boiko@gmail.com','Mariia','Boiko',8000,'2022.06.24',null, 
(select Id from Position where Name like 'Senior .Net Developer'),
(select Id from Company where Name like 'DataArt')),

('dmitriy.kravchenko@gmail.com','Dmitriy','Kravchenko',700,'2021.01.18','2022.08.13', 
(select Id from Position where Name like 'Junior .Net Developer'),
(select Id from Company where Name like 'Vector')),

('denys.itkin@gmail.com','Denys','Itkin',3500,'2020.03.30','2021.09.5', 
(select Id from Position where Name like 'Project Manager'),
(select Id from Company where Name like 'Nix')),

('petr.petrov@gmail.com','Petr','Petrov',30000,'2020.08.10', null, 
(select Id from Position where Name like 'Director'),
(select Id from Company where Name like 'DataArt')),

('danil.braznik@gmail.com','Danil','Braznik',32000,'2021.11.17', null, 
(select Id from Position where Name like 'Director'),
(select Id from Company where Name like 'Epam')),

('dmitriy.gubin@gmail.com','Dmitriy','Gubin',31000,'2022.04.19', null, 
(select Id from Position where Name like 'Director'),
(select Id from Company where Name like 'Nix')),

('ivan.kazuta@gmail.com','Ivan','Kazuta',33000,'2020.08.10', null,
(select Id from Position where Name like 'Director'),
(select Id from Company where Name like 'Vector'));

--After Migration-->

update Company
set DirectorId = (select empl.Id
					from (Employee empl inner join Position pos on empl.PositionId=pos.Id) 
					inner join Company com on empl.CompanyId=com.Id
					where pos.Name like 'Director'and com.Name like 'DataArt')
where Name like 'DataArt';

update Company
set DirectorId = (select empl.Id
					from (Employee empl inner join Position pos on empl.PositionId=pos.Id) 
					inner join Company com on empl.CompanyId=com.Id
					where pos.Name like 'Director' and com.Name like 'Epam')
where Name like 'Epam';

update Company
set DirectorId = (select empl.Id
					from (Employee empl inner join Position pos on empl.PositionId=pos.Id) 
					inner join Company com on empl.CompanyId=com.Id
					where pos.Name like 'Director' and com.Name like 'Global Logic')
where Name like 'Global Logic';

update Company
set DirectorId = (select empl.Id
					from (Employee empl inner join Position pos on empl.PositionId=pos.Id) 
					inner join Company com on empl.CompanyId=com.Id
					where pos.Name like 'Director' and com.Name like 'Nix')
where Name like 'Nix';

update Company
set DirectorId = (select empl.Id
					from (Employee empl inner join Position pos on empl.PositionId=pos.Id) 
					inner join Company com on empl.CompanyId=com.Id
					where pos.Name like 'Director' and com.Name like 'Vector')
where Name like 'Vector';