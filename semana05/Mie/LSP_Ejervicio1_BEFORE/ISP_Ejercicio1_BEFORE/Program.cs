namespace ISP_Ejercicio1_BEFORE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrinterTask task = new HPLaserJetPrinter();
            task.Fax("Contenido");

        }
    }
}
