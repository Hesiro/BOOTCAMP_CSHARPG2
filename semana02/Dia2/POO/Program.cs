class Automovil
{
    //atributos
    public string placa;
    string color;
    string marca;
    string modelo;

    //constructor
    public Automovil(string pl, string co, string ma, string mo)
    {
        this.placa = pl;
        this.color = co;
        this.marca = ma;
        this.modelo = mo;
    }
    //metodos
    public void Encender()
    {
        Console.WriteLine($"Encendiento el auto { this.marca }");
    }
}

class Program
{
    static void Main()
    {
        Automovil vw = new Automovil("CH.1234", "ROJO", "VOLKWAGEN","ESCARABAJO");
        Console.WriteLine($"Placa: {vw.placa}");
        vw.Encender();

        Console.WriteLine("CREA TU PROPIO AUTO");
        Console.WriteLine("MARCA:");
        string marca = Console.ReadLine();

        Automovil autoPropio = new Automovil("ASDF", "ROJO", marca, "NN");
        autoPropio.Encender();
    }
}