create table Encargados(
Id_Encargado int,
Nombre varchar(50),
Celular Bigint,
Sueldo decimal(8,0),
Correo varchar(30),
Constraint pk_Encargados Primary Key (Id_Encargado)
);

create table Almacenes(
Id_Almacen int,
Direccion varchar(50),
Telefono varchar(30),
Id_Encargado int,
Constraint pk_Almacenes Primary Key (Id_Almacen),
Constraint fk_Id_Encargado Foreign Key (Id_Encargado)
references Encargados(Id_Encargado)
);

create table Productos(
Id_producto int,
Descripcion varchar(50),
Precio_Unitario decimal(5,2),
Stock int,
Id_Almacen int,
Constraint pk_productos primary key (Id_producto),
constraint fk_Id_Almacen foreign key (Id_Almacen) references Almacenes(Id_Almacen)
);