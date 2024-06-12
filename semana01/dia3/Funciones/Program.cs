//FUNCIONES


int SumarDosNumeros (int numero1, int numero2)
{
    int resultado = numero1 + numero2;
    return resultado;
}

double AreaTriangulo(double baseT, double alturaT)
{
    return baseT * alturaT / 2;
}

double AreaRectangulo(double baseT, double alturaT)
{
    return baseT * alturaT;
}

double baseTriangulo = 0;
double alturaTriangulo = 0;
Console.WriteLine("CALCULAR AREA DE UN TRIANGULO");
Console.WriteLine("Ingrese la base del triangulo");
baseTriangulo = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo");
alturaTriangulo = double.Parse(Console.ReadLine());

Console.WriteLine($"EL AREA DEL TRIANGULO ES {AreaTriangulo(baseTriangulo, alturaTriangulo).ToString("N2")}");