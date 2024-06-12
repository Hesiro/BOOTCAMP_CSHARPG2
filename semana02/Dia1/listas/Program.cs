//List<string> dias = new List<string> { "Lunes", "Martes","Miercoles","Jueves"};
//Console.WriteLine(dias);
//Console.WriteLine(String.Join(", ", dias));
//dias.Add("Viernes");
//Console.WriteLine(String.Join(", ", dias));
//dias.RemoveAt(3);
//Console.WriteLine(String.Join(", ", dias));
//dias[0] = "Domingo";
//Console.WriteLine(String.Join(", ", dias));
//foreach (var item in dias)
//{
//    Console.WriteLine(item);
//}
List<double> notas = new List<double>();
Console.WriteLine("ESCRIBA NOTAS DE LOS ESTUDIANTES");
while (true)
{
    Console.WriteLine("Ingrese Nota: ");
    string nota = Console.ReadLine();

    if(nota.ToLower() == "fin")
    {
        break;
    }
    else
    {
        notas.Add(double.Parse(nota));
    }
}
Console.WriteLine("=============NOTAS=============");
Console.WriteLine(string.Join(", ", notas));
Console.WriteLine($"La nota mayor es: {notas.Max()}");
Console.WriteLine($"La nota menor es: {notas.Min()}");
Console.WriteLine($"La nota promedio es: {notas.Average()}");