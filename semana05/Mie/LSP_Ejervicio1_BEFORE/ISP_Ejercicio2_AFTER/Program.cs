namespace ISP_Ejercicio2_AFTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicicleta bici = new Bicicleta();
            bici.Move();
            Console.WriteLine(bici.GetNumberOfWheel());

            Automovil auto = new Automovil();
            auto.Move();
            Console.WriteLine(auto.GetNumberOfWheel());
            Console.WriteLine(auto.StartEngine());
            Console.WriteLine(auto.StopEngine());
        }
    }
}
