namespace ISP_Ejercicio1_AFTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HPLaserJetPrinter hpTask = new HPLaserJetPrinter();
            SimplePrinter spTask = new SimplePrinter();
            hpTask.Fax("Contenido");
            hpTask.Print("Contenido");
            hpTask.Scan("Contenido");
            spTask.Print("Contenido");
            spTask.Scan("Contenido");
        }
    }
}
