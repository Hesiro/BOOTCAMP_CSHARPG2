namespace Ejercicio1_After
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RESERVAS DE HOTEL");
            Console.WriteLine();
            Console.WriteLine("Reservar para primer usuario");
            var booking1 = new Booking 
            { 
                Usuario = new Usuario 
                { 
                    Name = "Pedro Gutierrez",
                    Email = "pedro.gutierrez@correo.com"
                },
                CheckIn = new DateTime(2024,07,01,10,40,0),
                CheckOut = new DateTime(2024, 07, 02, 14, 40, 0)
            };
            Console.WriteLine(new BookingService().Create(booking1));

            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine("Reservar para segundo usuario");
            var booking2 = new Booking
            {
                Usuario = new Usuario
                {
                    Name = "",
                    Email = "alfonso.com"
                },
                CheckIn = new DateTime(2024, 07, 06, 00, 00, 0),
                CheckOut = new DateTime(2024, 07, 04, 00, 00, 0)
            };
            Console.WriteLine(new BookingService().Create(booking2));
        }
    }
}
