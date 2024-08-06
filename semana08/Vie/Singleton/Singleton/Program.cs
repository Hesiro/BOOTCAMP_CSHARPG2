namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Console.WriteLine(new SingletonContainer().GetPopulation("Santiago").ToString());
            Console.WriteLine(SingletonContainer.Instance.GetPopulation("Santiago").ToString());
            Console.WriteLine(new SingletonFinder().GetTotalPopulation(new List<string> { "Buenos Aires", "La Paz" }).ToString());
        }
    }
}
