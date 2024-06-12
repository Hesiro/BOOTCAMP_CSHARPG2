Dictionary<string,string> capitales = new Dictionary<string, string> {
    {"Perú","Lima" },
    { "Ecuador", "Quito"},
    {"Chile","Santiago" },
    {"Colombia", "Bogotá" }
};

Console.WriteLine("Ingrese un país: ");
string pais = Console.ReadLine();
if (capitales.ContainsKey(pais))
    Console.WriteLine($"La capital de {pais} es {capitales[pais]}");
else
{ Console.WriteLine($"No se encontro capital de {pais}");
    Console.WriteLine("Ingrese la capital del pais");
    string nuevaCapital = Console.ReadLine();
    capitales[pais] = nuevaCapital;

}

foreach (var capital in capitales)
{
    Console.WriteLine($"{capital.Key} : {capital.Value}");
}
