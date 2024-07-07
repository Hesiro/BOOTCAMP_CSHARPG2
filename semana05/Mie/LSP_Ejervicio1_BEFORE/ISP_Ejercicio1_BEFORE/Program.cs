namespace ISP_Ejercicio1_BEFORE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrinterTask hpTask = new HPLaserJetPrinter();
            IPrinterTask spTask = new SimplePrinter();
            hpTask.Fax("Contenido");
            spTask.Print("Contenido");

        }
    }
}
