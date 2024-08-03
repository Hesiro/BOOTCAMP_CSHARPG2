CREATE TABLE Biblioteca(
	Id_Biblioteca INT PRIMARY KEY,
	Ubicacion VARCHAR(30),
	Telefono BIGINT
)

CREATE TABLE Generos_Libros(
	Id_Genero INT PRIMARY KEY,
	Genero VARCHAR(50)
)

CREATE TABLE Clientes(
	Id_Cliente INT PRIMARY KEY,
	Nombre_Cliente VARCHAR(50),
	Celular_Cliente BIGINT,
	Correo_Cliente VARCHAR(150),
	Estado_Cliente VARCHAR(1),
	Fecha_Nacimiento DATE
)

CREATE TABLE Encargados(
	Id_Encargado INT PRIMARY KEY,
	Nombre_Encargado VARCHAR(50),
	Correo_Encargado VARCHAR(150),
	Celular_Encargado BIGINT,
	Id_Biblioteca INT,
	CONSTRAINT fk_id_biblioteca_encargados FOREIGN KEY (Id_Biblioteca) REFERENCES Biblioteca(Id_Biblioteca)
)

CREATE TABLE Libros(
	Id_Libro INT PRIMARY KEY,
	Nombre VARCHAR(50),
	Autor VARCHAR(30),
	Editorial VARCHAR(30),
	Stock INT,
	Precio_Unitario DECIMAL(4,2),
	Año_Edicion VARCHAR(4),
	Id_Genero INT,
	CONSTRAINT fk_id_genero_libros FOREIGN KEY (Id_Genero) REFERENCES Generos_Libros(Id_Genero)
)

CREATE TABLE Venta_libros(
	Id_Venta_Libro INT PRIMARY KEY,
	Id_Libro INT,
	Id_Biblioteca INT,
	Id_Cliente INT,
	Cantidad INT,
	Fecha_Venta DATE,
	CONSTRAINT fk_id_libro_libros FOREIGN KEY (Id_libro) REFERENCES Libros(Id_Libro),
	CONSTRAINT fk_id_biblioteca_Biblioteca FOREIGN KEY (Id_Biblioteca) REFERENCES Biblioteca(Id_Biblioteca),
	CONSTRAINT fk_id_cliente_cliente FOREIGN KEY (Id_Cliente) REFERENCES Clientes(Id_Cliente)
)

CREATE TABLE Alquileres_Libros(
	Id_Alquiler_Libro INT PRIMARY KEY,
	Id_Libro INT,
	Id_Biblioteca INT,
	Id_Cliente INT,
	Fecha_Entrega DATE,
	Fecha_Devolucion DATE,
	Estado_Libro VARCHAR(1),
	CONSTRAINT fk_id_libro_a_libros FOREIGN KEY (Id_libro) REFERENCES Libros(Id_Libro),
	CONSTRAINT fk_id_biblioteca_a_Biblioteca FOREIGN KEY (Id_Biblioteca) REFERENCES Biblioteca(Id_Biblioteca),
	CONSTRAINT fk_id_cliente_a_cliente FOREIGN KEY (Id_Cliente) REFERENCES Clientes(Id_Cliente)
)