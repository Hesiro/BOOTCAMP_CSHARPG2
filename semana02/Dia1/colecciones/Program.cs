int[] notas;
int cantidad = 0;

Console.WriteLine("INGRESE CANTIDAD DE NOTAS");
cantidad = Convert.ToInt32(Console.ReadLine());

notas = new int[cantidad];
for (int i = 0; i< cantidad;i++)
{
    Console.WriteLine($"INGRESE NOTA {i+1} :");
    notas[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Se ingresaron todas las notas...");
Console.WriteLine($"EL PROMEDIO DE LAS NOTAS ES: {CalcularPromedioNotas(notas)}");
NotaMayor(notas);
NotaMenor(notas);

Double CalcularPromedioNotas(int[] notas)
{
    int cantidad = notas.Length;
    double sumaNotas = 0;   

    foreach (int i in notas)
    {
        sumaNotas += i;
    }

    return sumaNotas / cantidad;
    
}

void NotaMayor(int[] notas)
{    
    int mayor = notas[0];
    foreach (var item in notas)
    {
        if (item > mayor) mayor = item;
    }    
    Console.WriteLine($"LA NOTA MAYOR ES: {mayor}");
}

void NotaMenor(int[] notas)
{   
    int menor = notas[0];
    foreach (var item in notas)
    {
        if (item < menor) menor = item;
    }    
    Console.WriteLine($"LA NOTA MENOR ES: {menor}");
}
