//variables
/*string nombre = "henry";
int edad = 40;
Console.WriteLine("Hola, mi nombre es " + nombre + " y tengo " + edad + " años.");
Console.WriteLine("Hola, mi nombre es {0} y tengo {1} años.", nombre, edad);
Console.WriteLine($"Hola, mi nombre es {nombre} y tengo {edad} años.");*/

Console.WriteLine("¿Cual es tu nombre?");
string? nombreUsuario = Console.ReadLine();
int cantidadLetras = nombreUsuario.Trim().Replace(" ","").Length;
Console.WriteLine($"La cantidad de letras de tu nombre es: {cantidadLetras}");

DateTime fecha = new DateTime(1983, 12, 19);
DateTime hoy = DateTime.Today;
var diferencia = hoy - fecha;
Console.WriteLine($"Tu fecha de nacimiento es: {fecha.ToString("dddd, dd MMMM yyyy")}");
Console.WriteLine($"Y tu edad es {diferencia.Days / 365}");