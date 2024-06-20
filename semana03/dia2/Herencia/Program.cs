using Herencia.Models;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HERENCIA!\n");

            Alumno alumno = new Alumno("Henry Sifuentes", "henrywsr@gmail.com", 17);            
            alumno.Mostrar();            

            Console.WriteLine("\n");
            Profesor profesor = new Profesor("Cesar Mayta", "cmayta@gmail.com");
            profesor.Mostrar();
        }
    }
}
