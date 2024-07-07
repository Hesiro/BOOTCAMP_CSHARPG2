using SRP_Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        var report = new CourseReport();
        report.AddEntry(new CourseReportEntry { Name = ".Net y microservicios", Students = 15, Rating= 15});
        report.AddEntry(new CourseReportEntry { Name = "MAUI", Students = 10, Rating = 18 });
        

        var fileSaver = new FileSave();
        fileSaver.SaveToFile("Report","Report",report);

        Console.WriteLine(report.ToString());
        Console.ReadKey();
        
    }
}