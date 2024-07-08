using System.Reflection.PortableExecutable;

namespace Ejercicio1_After
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> persons = new List<IPerson>()
            {
                new Basico{ FirstName="Ana", LastName="Colonia"},
                new Gold{ FirstName="Ivan", LastName="Mariluz"},
                new Platinium{ FirstName="Pedro", LastName="Prado"},
                new Gold{ FirstName="George", LastName="Canta"},
                new Basico{ FirstName="Rosario", LastName="Chinchay"}
            };

            List<Membership> members = new List<Membership>();
            foreach (var person in persons) 
            {
                members.Add(person.IAccountService.Create(person));
            }

            Console.WriteLine("LISTA DE MIEMBROS");
            foreach (var member in members) {
                Console.WriteLine($"Bienvenido: {member.FirstName} {member.LastName} - Email: {member.Email} - ID: {member.Id} - Precio: {member.Price}");
            }
        }
    }
}
