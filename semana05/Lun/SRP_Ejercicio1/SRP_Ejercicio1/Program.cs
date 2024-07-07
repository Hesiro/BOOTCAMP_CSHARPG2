using SRP_Ejercicio1;

class Program
{ 
    static void Main()
    {
        //Console.WriteLine(new AccountService().Create("Henry Sifuentes","henrywsr@outlook.com", DateTime.Now));
        //Console.ReadLine();
        var appointmet = new Appointment { 
            Patient = new Patient {
            Email ="henry@outlook.com",
            Name = "Henry Sifuentes"},
            Time = new DateTime(2021,05,16,20,30,15)
        };
        Console.WriteLine(new AccountService().Create(appointmet));
    }
}