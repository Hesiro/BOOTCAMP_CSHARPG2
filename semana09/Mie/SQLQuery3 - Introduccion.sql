
CREATE TABLE Departamento(
	DepartamentoId INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(50)
);

CREATE TABLE Empleado(
	Id INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(50),
	Apelllido VARCHAR(50),
	DepartamentoId INT,
	FOREIGN KEY (DepartamentoId) REFERENCES Departamento(DepartamentoId)
);

CREATE TABLE Direccion(
	DireccionId INT PRIMARY KEY IDENTITY,
	Calle VARCHAR(100),
	Ciudad VARCHAR(50),
	EmpleadoId INT UNIQUE,
	FOREIGN KEY (EmpleadoId) REFERENCES Empleado(Id)
);

