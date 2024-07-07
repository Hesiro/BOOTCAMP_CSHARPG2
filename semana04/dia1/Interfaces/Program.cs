using Interfaces;

//List<IVehiculo> vehiculos = new List<IVehiculo>() {
//    new Coche(), new Moto(), new Coche(), new Moto()
//};

//foreach(IVehiculo vehiculo in vehiculos)
//{
//    vehiculo.Arrancar();
//}

Administrador admin = new Administrador();
Usuario user = new Usuario("henrywsr","456");

admin.Login("Pedro.Dias", "123456");
user.Login("Jose.Rios", "123456");