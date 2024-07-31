using System.Globalization;

namespace FactoryMethod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orden = new LimaPizzaStore();
            orden.CreatePizza("Napolitana");
        }
    }

    public class Pizza
    {
        public string Nombre { get; set; }
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public List<string> Extras { get; set; } = new List<string>();

        public void Preparar()
        {
            Console.WriteLine($"Preparando {Nombre}");
            Console.WriteLine($"Colocando masa... {Masa}");
            Console.WriteLine($"Agregando salsa... {Salsa}");
            Console.WriteLine($"Agregando ingredientes: {string.Join(",", Extras)}");
        }
        public void Cocinar()
        {
            Console.WriteLine($"Cocinando por 25 minutos a 100 grados");
        }
        public void Cortar() => Console.WriteLine($"Cortando la pizza en partes iguales");
        public void Encajar() => Console.WriteLine($"Encajando la pizza");
    }

    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string name);
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = (Pizza)null;
            //switch (type)
            //{
            //    case "Peperoni":
            //        pizza = new PeperoniPizza();
            //        break;
            //    case "Napolitana":
            //        pizza = new NapolitanaPizza();
            //        break;
            //    case "Vegetariana":
            //        pizza = new VegetarianaPizza();
            //        break;
            //}

            //if (pizza != null) { 
                pizza.Preparar();
                pizza.Cocinar();
                pizza.Cortar();
                pizza.Encajar();
            //}

            return pizza;
        }
    }

    internal class PeperoniPizza : Pizza {
        public PeperoniPizza() {
            Nombre = "Pizza de Pepperoni";
            Masa = "Masa delgada";
            Salsa = "Salsa de tomate";
            Extras.Add("Salsa de especias");
        }
    }

    internal class NapolitanaPizza : Pizza
    {
        public NapolitanaPizza()
        {
            Nombre = "Pizza de Napolitana";
            Masa = "Masa delgada";
            Salsa = "Salsa de tomate";
            Extras.Add("Aceite de oliva");
        }
    }

    internal class VegetarianaPizza : Pizza
    {
        public VegetarianaPizza()
        {
            Nombre = "Pizza de Napolitana";
            Masa = "Masa delgada";
            Salsa = "Salsa de tomate";
            Extras.Add("Pan de ajo");
        }
    }

    public class ArequipaPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string name)
        {
            switch (name)
            {
                case "Peperoni":
                    return new PeperoniPizza();
                    break;
                case "Napolitana":
                    return new NapolitanaPizza();
                    break;
                case "Vegetariana":
                    return new VegetarianaPizza();
                    break;
                default:
                    return null;
            }
        }
    }

    public class LimaPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string name)
        {
            switch (name)
            {
                case "Peperoni":
                    return new PeperoniPizza();
                    break;
                case "Napolitana":
                    return new NapolitanaPizza();
                    break;
                case "Vegetariana":
                    return new VegetarianaPizza();
                    break;
                default:
                    return null;
            }
        }
    }
}
