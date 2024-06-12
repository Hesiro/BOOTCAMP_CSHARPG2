//variables
double valorCompra = 3.741;
double valorVenta = 3.747;
int opcion = 0;
double montoOrigen;
double montoDestino;
//entradas
while (opcion != 3)
{
    Console.Clear();
    Console.WriteLine("==================================");
    Console.WriteLine("CONVERTIDOR DE MODEDAS VERSION 1.0");
    Console.WriteLine("==================================");
    Console.WriteLine(@"
    OPCION 1: Convertir de soles a dolares
    OPCION 2: Convertir de dolares a soles
    OPCION 3: Salir
");
    Console.WriteLine("Ingrese una opcion del menu: ");
    opcion = int.Parse(Console.ReadLine());
    //proceso
    switch (opcion)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("ELEGISTE CONVERTIR DE SOLES A DOLARES");
            Console.WriteLine("Ingrese monto en soles: ");
            montoOrigen = double.Parse(Console.ReadLine());
            montoDestino = montoOrigen / valorVenta;
            Console.WriteLine($"{montoOrigen} soles es igual a {montoDestino.ToString("N2")} dolares");
            Console.ReadLine();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("ELEGISTE CONVERTIR DE DOLARES A SOLES");
            Console.WriteLine("Ingrese monto en dolares: ");
            montoOrigen = double.Parse(Console.ReadLine());
            montoDestino = montoOrigen * valorCompra;
            Console.WriteLine($"{montoOrigen} dolares es igual a {montoDestino.ToString("N2")} soles");
            Console.ReadLine();
            break;
            case 3:
            Console.Clear();
            Console.WriteLine("ADIOS");            
            break;
        default:
            Console.Clear();
            Console.WriteLine("La opcion no es valida...Presione enter para continuar");
            Console.ReadLine();
            break;
    };
}
//salidas
