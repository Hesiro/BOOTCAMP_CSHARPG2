SELECT * FROM Almacenes;
SELECT * FROM Encargados;
SELECT * FROM Productos;

SELECT Nombre, Celular FROM Encargados;

SELECT Direccion, Telefono FROM Almacenes;

SELECT Descripcion, Precio_Unitario FROM Productos;

SELECT Nombre, Sueldo + 100 as Sueldo_Aumentado FROM Encargados;

SELECT Descripcion, Precio_Unitario * 1.1 AS Precio_Aumentado FROM Productos;

SELECT * FROM Encargados WHERE Sueldo >= 3000;

SELECT * FROM Productos WHERE Stock Between 100 and 200

SELECT * FROM Productos WHERE Descripcion like '%f%'

SELECT * FROM Encargados WHERE (Nombre like '%o%' or Nombre like '%O%') and sueldo not in (800, 1500, 2000)

SELECT Descripcion, Precio_Unitario, Stock, Precio_Unitario * Stock As Valor_Total FROM PRODUCTOS

SELECT Nombre as Encargado, Id_Almacen as Almacen, CONCAT(Nombre,' - ' ,Id_Almacen) as Asignacion FROM Encargados E INNER JOIN Almacenes A ON E.Id_Encargado = A.Id_Encargado

SELECT DISTINCT Descripcion, Precio_unitario FROM Productos

SELECT Nombre, Sueldo as Sueldo_Mensual, Sueldo *12 as Sueldo_Anual FROM Encargados

SELECT A.Id_Almacen, SUM(Stock) as Stock_Total FROM Almacenes A INNER JOIN Productos P ON A.Id_Almacen = P.Id_Almacen GROUP BY A.Id_Almacen

UPDATE Encargados
SET
	Sueldo = 3200
WHERE 
	Celular like '9%' AND Sueldo < 3200

UPDATE Productos
SET
	Stock = Stock * 1.05
WHERE
	Precio_Unitario > 20
	OR Id_Almacen = 5


DELETE FROM Productos
WHERE (Id_Almacen = 1 OR Id_Almacen = 2) AND Stock < 50


DECLARE @CANT INT;
SELECT @CANT = COUNT(Id_Encargado) FROM Encargados WHERE Sueldo > 3000 AND Correo like '%example.com%';
IF @CANT>0
	INSERT INTO Productos(Id_producto,Descripcion,Precio_Unitario,Stock,Id_Almacen)
	VALUES (11,5,'Producto 11', 25,5,5)

IF EXISTS(SELECT 1 FROM Encargados WHERE Sueldo > 3000 AND Correo like '%example.com')
BEGIN
	INSERT INTO Productos(Id_producto,Descripcion,Precio_Unitario,Stock,Id_Almacen)
	VALUES (11,5,'Producto 11', 25,5,5)
END