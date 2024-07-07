namespace LSP_Ejercicio2_BEFORE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Dog();
            Animal ave = new Bird();
            //perro.Fly();
            perro.MakeNoise();
            ave.Fly();
            ave.MakeNoise();
            Console.ReadKey();
        }
    }
}
