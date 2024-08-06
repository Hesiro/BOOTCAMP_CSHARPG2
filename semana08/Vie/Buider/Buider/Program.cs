namespace Buider_Before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var sandwitch = new Sandwitch("Pan de molde", "Tomates","Proteina A", "Mayonesa", "Queso chedar");

            var cheeseBurger = new SandwitchAssemble(new CheeseBurger());
            cheeseBurger.Assembly();

            Console.WriteLine($"Pan: {cheeseBurger.GetSandwitch.Pan}");
            Console.WriteLine($"Pan: {cheeseBurger.GetSandwitch.Proteina}");
            Console.WriteLine($"Pan: {cheeseBurger.GetSandwitch.Verduras}");
            Console.WriteLine($"Pan: {cheeseBurger.GetSandwitch.Queso}");
            Console.WriteLine($"Pan: {cheeseBurger.GetSandwitch.Condimentos}");
        }
    }
}
