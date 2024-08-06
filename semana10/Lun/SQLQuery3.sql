select nombre, genero from Libros L join Generos_Libros GL ON l.Id_Genero = gl.Id_Genero

select nombre_encargado, ubicacion from Biblioteca B join ENCARGADOS E on B.Id_Biblioteca = E.Id_Biblioteca

select Nombre_Cliente, sum(Cantidad) from Clientes C left join Venta_libros VL on C.Id_Cliente = VL.Id_Cliente
group by Nombre_Cliente;

select Nombre_Cliente, coalesce(sum(Cantidad),0) as cantidadTotal from Clientes C left join Venta_libros VL on C.Id_Cliente = VL.Id_Cliente
group by Nombre_Cliente;

select Nombre, coalesce(sum(Cantidad),0) as cantidadTotal  
from Venta_libros VL right join Libros L 
on L.Id_Libro = VL.Id_Libro 
group by Nombre;

select ubicacion, Nombre_Encargado 
from Biblioteca B full join ENCARGADOS E
on b.Id_Biblioteca = E.Id_Biblioteca

select Nombre_Cliente, Correo_Cliente, Fecha_Nacimiento, Ubicacion, Estado_Libro from Clientes C
inner join Alquileres_Libros A On c.Id_Cliente = a.Id_Cliente
inner join Biblioteca B On a.Id_Biblioteca = b.Id_Biblioteca
where YEAR(Fecha_Nacimiento) between 1990 and 1995

select Celular_Encargado, Telefono, Nombre_Cliente, Correo_Cliente, Nombre, Autor, Año_Edicion, Cantidad, Fecha_Venta 
from ENCARGADOS E 
inner join Biblioteca B on e.Id_Biblioteca = b.Id_Biblioteca
inner join Venta_libros V On V.Id_Biblioteca = B.Id_Biblioteca
inner join Clientes C on C.Id_Cliente = V.Id_Cliente
inner join Libros L on L.Id_Libro = v.Id_Libro
where Cantidad > 8;
