namespace LSP_Ejervicio1_BEFORE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new FootbalPlayer();
            player.FirstName = "Henry";
            player.LastName = "Sifuentes";
            player.AssignTeam(new Team { Name = "Melgar" });
            player.SetCategory(PlayerCategory.Professional);

            Console.WriteLine($"{player.FirstName} - {player.LastName} - {player.GetTeam()} - {player.Category}");

            Console.WriteLine("\n\n");
            //palyer.SetCategory(PlayerCategory.Profesional);
        }
    }
}
