--drop table batch;
--drop table trainers;
--drop table associates;
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
('Drew', 'AZ');

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

-- 1) Add 5 associate to the associate table
insert into associates (associateName, associateState) values
('Jacob', 'CA'),
('Zar', 'MO'),
('James', 'MN'),
('Mann', 'FL'),
('Vincent', 'CA');

-- 2) Get all associates that live in a certain state
Select * from associates where associateState='CA';

-- 3) Get the numbner of associates living in the various states
select associateState, count(id) from associates 
group by associateState order by 
count(associateState) asc;

select associateState, count(id) from associates 
group by associateState order by 
count(associateState) desc;

-- 4a) Get all trainers without associates
select trainername, campus from trainers left join batch 
on trainers.id = batch.trainerId
except
select trainername, campus from trainers right join batch
on trainers.id = batch.trainerId

-- 4b) Get all the associates mapped to a trainer
select * from associates inner join batch 
on associates.id = batch.associateId 
where batch.trainerId = 1

select * from associates inner join batch 
on associates.id = batch.associateId;

-- 4c) Get all associates without a trainer
select distinct * from associates 
left outer join batch on associates.id = batch.associateid 
where batch.trainerid is null;




