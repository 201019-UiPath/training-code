drop table batch;
drop table trainers;
drop table associates;
create table associates
(
	id serial primary key,
	associateName varchar(100) not null,
	associateState varchar(2) not null
);

create table trainers
(
	id serial primary key,
	trainerName varchar(100) not null,
	campus varchar(3) not null
);

create table batch
(
	id serial primary key,
	associateID int references associates (id),
	trainerID int references trainers (id)
);

insert into associates (associateName, associateState) values
('Michael', 'CA'),
('Brian', 'MN'),
('Lindsey', 'SC'),
('Angela', 'TX'),
('Drew', 'AZ'),
('Anthony','Nj'), -- anthony to angela were added as part of the assignment
('Carson','NY'),
('Andres','WV'),
('John','KY'),
('Angela','NY');

insert into trainers (trainerName, campus) values
('Marielle', 'USF'),
('Pushpinder', 'UTA'),
('Nick', 'UTA'),
('Sierra', 'WVU'),
('Wezley', 'USF');

insert into batch (associateID, trainerID) values
(1,1),
(1,2),
(2,1),
(2,2),
(3,1),
(3,2),
(4,1),
(4,2),
(5,4);
-- above = predone, below = group work

Select * from associates;

Select * from associates where associatestate = 'NY';

select count (*) from associates where associatestate = 'NY';

select count (associatestate) from associates;


SELECT associatestate, COUNT(id) 
from associates
GROUP BY  associatestate
ORDER BY COUNT(id) DESC;

SELECT associatestate, COUNT(id) 
from associates
GROUP BY  associatestate
having count(id) >1
ORDER BY COUNT(id) Asc;

select * from trainers;
select * from batch;
select * from associates;

select trainername from trainers left outer join batch on trainers.id = batch.trainerid 
where associateid isnull;

select associatename from associates inner join batch on associates.id = batch.associateid 
group by associatename;

select associatename from associates left outer join batch on associates.id = batch.associateid 
where trainerid isnull;
