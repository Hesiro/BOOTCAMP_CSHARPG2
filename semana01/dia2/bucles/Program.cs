Console.WriteLine("Ingrese la tabla a multiplicar");
int tabla = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= 12; i++)
{
    Console.WriteLine($"{tabla} x {i} = {tabla*i}");
}
