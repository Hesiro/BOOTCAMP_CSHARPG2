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
	Id_Flight int,
	constraint fk_Users_Flight foreign key (Id_Flight) references Flight(Id)
);

insert into Flight(Airline, FlightNumber, Destination, AirPlaneType)
values 
	('American Airlines', 'AA100', 'New York', 'Boeing 737'),
	('Delta Airlines', 'DL200', 'Los Angeles', 'Airbus A320'),
	('United Airlines', 'UA300', 'Chicago','Boeing 777');