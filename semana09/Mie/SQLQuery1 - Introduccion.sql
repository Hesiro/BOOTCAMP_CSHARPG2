USE [IntroduccionSql]
GO

INSERT INTO [dbo].[GlobalCorp]
           ([Id]
           ,[Nombre]
           ,[Apellido]
           ,[Edad]
           ,[Sueldo]
           ,[FechaNaciminto]
           ,[HoraEntrada]
           ,[FechaHoraRegistro]
           ,[Descripcion]
           ,[Documento]
           ,[Foto]
           ,[Estado]
           ,[Comentario]
           ,[Archivos]
           ,[Precio]
           ,[Booleano]
           ,[Identificacion]
           ,[PuntoGeografico])
     VALUES
           (1
           ,'Henry Williams'
           ,'Sifuentes Romisoncco'
           ,40
           ,2500
           ,'1983-12-19'
           ,'15:45:00'
           ,'2024-5-12 8:00:00'
           ,'Empleado del mes'
           ,0x4D7953746174696342696E61727944617461
           ,0x89504E470D0A1A0A0000000D4948445200000001000000010806000000
           ,'A'
           ,'Esto es un comentario de prueba'
           ,'<Empleado><Nombre>Juan</Nombre><Apellido>Perez</Apellido></Empleado>'
           ,3200.85
           ,1
           ,NEWID()
           ,geography::STGeomFromText('POINT(-122.360 47.656)', 4326));
GO


