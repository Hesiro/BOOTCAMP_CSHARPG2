select id_libro, nombre, Stock, Stock + 10 as nuevostock, Stock*3 as stocktriple from Libros

select Nombre_Cliente + ' ' + Correo_Cliente + ' ' + CAST(Celular_Cliente as varchar) as informacioncliente from Clientes

select cast(Id_Genero as nvarchar) + ' ' + Genero from Generos_Libros

select Id_Cliente, Id_Libro, Id_Alquiler_Libro, Id_Biblioteca  from Alquileres_Libros order by Fecha_Devolucion  desc

select COUNT(Id_Cliente) as Cantidad_Clientes from Clientes

select AVG(stock) as PromedioStock from Libros

select Fecha_Entrega from Alquileres_Libros
where Id_Alquiler_Libro = (select MAX(Id_Alquiler_Libro) from Alquileres_Libros)

select genero, sum(Stock) as total from Generos_Libros gl inner join Libros l on gl.Id_Genero = l.Id_Genero
group by Genero

select l.id_libro, Nombre, AVG(Cantidad) from Libros l inner join Venta_libros vl on l.Id_Libro = vl.Id_Libro
group by l.id_libro, Nombre

select id_cliente, sum(Cantidad)as total from Venta_libros
group by Id_Cliente 
having sum(Cantidad)>=10 and sum(Cantidad)<=50


