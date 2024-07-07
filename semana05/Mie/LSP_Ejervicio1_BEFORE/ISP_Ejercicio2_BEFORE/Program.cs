namespace ISP_Ejercicio2_BEFORE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehiculo bici = new Bicicleta();
            bici.Move();
            Console.WriteLine(bici.GetNumberOfWheel());

            IVehiculo auto = new Automovil();
            auto.Move();
            Console.WriteLine(auto.GetNumberOfWheel());
            Console.WriteLine(auto.StartEngine());
            Console.WriteLine(auto.StopEngine());
        }
    }
}
