namespace FluentBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new SandwitchBuilder()
                .AddVerduras()
                .AddCondimento()
                .AddPan()
                .AddQueso()
                .AddProteina();

            Sandwitch sandwitch = builder.Sandwitch;
            Console.WriteLine($"Sandwitvhe: {sandwitch.Pan}");
        }
    }
}
