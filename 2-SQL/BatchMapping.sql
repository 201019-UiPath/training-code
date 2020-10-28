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