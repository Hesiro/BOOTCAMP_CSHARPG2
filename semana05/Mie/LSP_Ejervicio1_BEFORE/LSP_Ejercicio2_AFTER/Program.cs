namespace LSP_Ejercicio2_AFTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Dog();
            animal.Noise = "Guau  guau";
            animal.MakeNoise();            

            ICanFly animal2 = new Bird();
            animal2.Noise = "Birddddddd";
            animal2.MakeNoise();
            animal2.Fly();

            Console.ReadKey();
        }
    }
}
