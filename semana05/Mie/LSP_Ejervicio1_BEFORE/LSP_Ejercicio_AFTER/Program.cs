using System.Numerics;

namespace LSP_Ejercicio_AFTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayerTeam footballPalyer = new FootballPlayer();
            footballPalyer.FirstName = "Henry";
            footballPalyer.LastName = "Sifuentes";
            footballPalyer.AssignTeam(new Team { Name = "Peru Campeon"});
            footballPalyer.SetCategory(PlayerCategory.Amateur);
            Console.WriteLine($"{footballPalyer.FirstName} - {footballPalyer.LastName} - {footballPalyer.GetTeam()} - {footballPalyer.PlayerCategory}");

            IPlayer tennisPlayer = new TennisPlayer();
            tennisPlayer.FirstName = "Irene";
            tennisPlayer.LastName = "Romisoncco";
            tennisPlayer.SetCategory(PlayerCategory.Professional);
            Console.WriteLine($"{tennisPlayer.FirstName} - {tennisPlayer.LastName} - {tennisPlayer.PlayerCategory}");
        }
    }
}
