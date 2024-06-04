/*
 * Programa para operaciones matematica
 * 1 datos de entrada
 * 2 proceso
 * 3 datos de salida
 */
Console.WriteLine("OPERACIONES MATEMATICAS");


Console.WriteLine("Ingrese el primer numero");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el tipo de operacion (suma, resta, multiplicacion, division)");
string? operador = Console.ReadLine();

int resultado = 0;
string simbolo = "";

switch (operador)
{
    case "suma":
        resultado = a + b;
        simbolo = "+";
        break;
    case "resta":
        resultado = a - b;
        simbolo = "-";
        break;
    case "multiplicacion":
        resultado = a * b;
        simbolo = "x";
        break;
    case "division":
        resultado = a / b;
        simbolo = "/";
        break;
    default:
        simbolo = "";           
        break;
}

if (simbolo == "")
    Console.WriteLine("Operacion no reconocida");
else
Console.WriteLine($"La {operador} de {a} {simbolo} {b} es {resultado}");
