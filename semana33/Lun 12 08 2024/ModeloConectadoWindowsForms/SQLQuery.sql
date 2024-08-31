create table Flight
(
	Id int primary key identity,
	Airline varchar(150),
	FlightNumber varchar(150),
	Destination varchar(150),
	AirPlaneType varchar(150)
);

create table Users
(
	Id int primary key identity,
	Name varchar(150),
	Email varchar(150),
	Address varchar(150),
	Age int,
	Id_Flight int,
	constraint fk_Users_Flight foreign key (Id_Flight) references Flight(Id)
);

insert into Flight(Airline, FlightNumber, Destination, AirPlaneType)
values 
	('American Airlines', 'AA120', 'New York', 'Boeing 777'),
	('Delta Airlines', 'DL200', 'Los Angeles', 'Airbus A320'),
	('United Airlines', 'UA300', 'Chicago','Boeing 777');

select * from Flight

insert into Users (Name, Email, Address, Age, Id_Flight)
values
	('Henry', 'henrywsr@outlook.com', 'AAHH Cerrro Atarraya E8', 40, 1),
	('Irene', 'iromisoncco@gmail.com', 'Urb. San Pedro', 59, 2),
	('Liz', 'lizmasiro@gmail.com', 'AAHH Cerrro Atarraya E8', 33, 1),
	('David', 'david@outlook.com', 'Urb. San Pedro', 64, 2);

select * from Users;

--drop table Users