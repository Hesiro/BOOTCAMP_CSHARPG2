INSERT INTO Biblioteca(Id_Biblioteca, Ubicacion, Telefono) VALUES(1, 'Pativilca',97746585);
INSERT INTO Biblioteca(Id_Biblioteca, Ubicacion, Telefono) VALUES(2, 'Paramonga',98631458);
INSERT INTO Biblioteca(Id_Biblioteca, Ubicacion, Telefono) VALUES(3, 'Supe Pueblo',96487513);
INSERT INTO Biblioteca(Id_Biblioteca, Ubicacion, Telefono) VALUES(4, 'Puerto Supe',99874562);
INSERT INTO Biblioteca(Id_Biblioteca, Ubicacion, Telefono) VALUES(5, 'Barranca',95487546);

INSERT INTO generos_libros VALUES (1, 'Drama');
INSERT INTO generos_libros VALUES (2, 'Comedia');
INSERT INTO generos_libros VALUES (3, 'Terror');
INSERT INTO generos_libros VALUES (4, 'Accion');
INSERT INTO generos_libros VALUES (5, 'Melodrama');
INSERT INTO generos_libros VALUES (6, 'Teatro');
INSERT INTO generos_libros VALUES (7, 'Suspenso');
INSERT INTO generos_libros VALUES (8, 'Educativo');
INSERT INTO generos_libros VALUES (9, 'Accion');
INSERT INTO generos_libros VALUES (10, 'Animado');

INSERT INTO clientes VALUES (1, 'Gabriel Retamozo', 987234517, 'gabrielsxf@gmail.com', 'N', '1995-02-28');
INSERT INTO clientes VALUES (2, 'Jorge Diaz', 995234517, 'jorgediaz@gmail.com', 'N', '1980-10-15');
INSERT INTO clientes VALUES (3, 'Alejandra Perez', 987234679, 'aleperezf@gmail.com', 'N', '1990-05-01');
INSERT INTO clientes VALUES (4, 'Camilo Forse', 987567780, 'camilof@gmail.com', 'N', '1996-07-20');
INSERT INTO clientes VALUES (5, 'Alejandro Anguila', 987234654, 'alejandrof@gmail.com', 'N', '1991-10-10');
INSERT INTO clientes VALUES (6, 'patricio Gomez', 923434679, 'gomezp@gmail.com', 'N', '1989-10-02');
INSERT INTO clientes VALUES (7, 'Luis Ramos', 987235559, 'ramosluis@gmail.com', 'N', '1999-09-28');
INSERT INTO clientes VALUES (8, 'Cynthia Quispe', 967034679, 'cynthiaq@gmail.com', 'N', '1995-02-21');
INSERT INTO clientes VALUES (9, 'Luis Delgado', 987444679, 'luisd@gmail.com', 'N', '1990-02-17');
INSERT INTO clientes VALUES (10, 'Abelardo Quiñonez', 967834679, 'abelardo98@gmail.com', 'N', '1988-04-21');

INSERT INTO Encargados VALUES (1, 'gabriel fernando', 'gabriel@gmail.com', 987034127, 3);
INSERT INTO encargados VALUES (2, 'abel andrade', 'abelll@gmail.com', 987032346, 2);
INSERT INTO encargados VALUES (3, 'rocio paredes', 'rocioparedes@gmail.com', 987217127, 3);
INSERT INTO encargados VALUES (4, 'andres garcia', 'andres@gmail.com', 987217127, 1);
INSERT INTO encargados VALUES (5, 'riquelme paz', 'riquelme@gmail.com', 987254443, 4);
INSERT INTO encargados VALUES (6, 'paola hurtado', 'paola@gmail.com', 987216655, 1);
INSERT INTO encargados VALUES (7, 'jacky mena', 'jacky@gmail.com', 987218907, 4);
INSERT INTO encargados VALUES (8, 'jorge man', 'jorgeg@gmail.com', 987217345, 2);
INSERT INTO encargados VALUES (9, 'fernando garcia', 'fernando65@gmail.com', 900067127, 5);
INSERT INTO encargados VALUES (10, 'felix montero', 'monterof@gmail.com', 985432127, 5);

INSERT INTO libros VALUES (1, 'principito', 'gabriel', 'sanluis', 10, 20, '2010', 5);
INSERT INTO libros VALUES (2, 'las aventuras de jose', 'palermo', 'san luis', 20, 16.7, '2014', 4);
INSERT INTO libros VALUES (3, 'gallinazo sin plumas', 'andres', 'coveñas', 25, 19.8, '2018', 5);
INSERT INTO libros VALUES (4, 'donjuan tenorio', 'editorial 4', 'coveñas', 25, 26, '2018', 3);
INSERT INTO libros VALUES (5, 'libro 5', 'autor 5', 'editorial 5', 20, 19.8, '2016', 2);
INSERT INTO libros VALUES (6, 'libro 6', 'autor 6', 'editorial 6', 15, 19.8, '2012', 1);
INSERT INTO libros VALUES (7, 'libro 7', 'autor 7', 'editorial 7', 22, 16.5, '2013' ,6);
INSERT INTO libros VALUES (8, 'libro 8', 'autor 8', 'editorial 8', 21, 15.5, '2011', 7);
INSERT INTO libros VALUES (9, 'libro 9', 'autor 9', 'editorial 9', 20, 20, '2010', 4);
INSERT INTO libros VALUES (10, 'libro 10', 'autor 10', 'editorial 10', 15, 25, '2013', 8);

INSERT INTO venta_libros VALUES (1, 5, 4, 6, 2, '2023-01-15');
INSERT INTO venta_libros (id_venta_libro, id_libro, id_biblioteca, id_cliente, cantidad, fecha_venta) VALUES (2, 1, 5, 6, 1, '2023-02-20');
INSERT INTO venta_libros VALUES (3, 6, 2, 3, 10, '2023-03-25');
INSERT INTO venta_libros VALUES (4, 4, 4, 1, 4, '2023-04-30');
INSERT INTO venta_libros VALUES (5, 4, 5, 2, 2, '2023-05-05');
INSERT INTO venta_libros VALUES (6, 3, 1, 7, 1, '2023-06-10');
INSERT INTO venta_libros VALUES (7, 1, 4, 8, 5, '2023-07-15');
INSERT INTO venta_libros VALUES (8, 2, 3, 1, 3, '2023-08-20');

INSERT INTO alquileres_libros VALUES (1, 5, 4, 6, CAST('2022-03-25' AS DATE), CAST('2022-05-25' AS DATE), 'N');
INSERT INTO alquileres_libros VALUES (2, 6, 1, 7, CAST('2021-01-02' AS DATE), CAST('2021-03-02' AS DATE), 'N');
INSERT INTO alquileres_libros VALUES (3, 3, 3, 5, CAST('2022-07-13' AS DATE), CAST('2022-09-13' AS DATE), 'N');
INSERT INTO alquileres_libros VALUES (4, 1, 2, 4, CAST('2022-12-20' AS DATE), CAST('2023-02-20' AS DATE), 'N');
INSERT INTO alquileres_libros VALUES (5, 4, 3, 8, CAST('2021-09-19' AS DATE), CAST('2021-11-19' AS DATE), 'N');
INSERT INTO alquileres_libros VALUES (6, 6, 4, 1, CAST('2021-12-11' AS DATE), CAST('2022-02-11' AS DATE), 'N');
INSERT INTO alquileres_libros VALUES (7, 4, 3, 10, CAST('2022-05-10' AS DATE), CAST('2022-07-10' AS DATE), 'N');
INSERT INTO alquileres_libros VALUES (8, 8, 3, 8, CAST('2022-08-02' AS DATE), CAST('2022-10-02' AS DATE), 'N');
INSERT INTO alquileres_libros VALUES (9, 1, 2, 4, CAST('2023-04-15' AS DATE), CAST('2023-06-15' AS DATE), 'N');
INSERT INTO alquileres_libros VALUES (10, 2, 3, 2, CAST('2023-03-03' AS DATE), CAST('2023-05-03' AS DATE), 'N');

