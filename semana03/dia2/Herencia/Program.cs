using Herencia.Models;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, Henry!");

            Alumno alumno = new Alumno();
            alumno.Nombre = "Henry Sifuentes";
            alumno.Email = "henrywsr@gmail.com";
            alumno.Nota = 17;
            alumno.Mostrar();
            alumno.MostrarNota();

            Profesor profesor = new Profesor();
            profesor.Nombre = "Cesar Mayta";
            profesor.Email = "cmayta@gmail.com";
            profesor.Mostrar();
        }
    }
}
