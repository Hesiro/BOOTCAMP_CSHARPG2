namespace FactoryMethod1
{
    internal class Program
    {
        public class Usuario
        {
            public string Name {  get; private set; }
            public string Email {  get; private set; }
            public string Country {  get; private set; }

            private Usuario(string name, string email, string country)
            {
                Name = name;
                Email = email;
                Country = country;
            }

            public class UsuarioFactory
            {
                public static Usuario CreateWithDefaulCountry(string name, string email)
                {
                    return new Usuario(name, email, "Perú");
                }
                public static Usuario CreateWithDefaultEmail(string name, string country)
                {
                    return new Usuario(name, name + "@outlook.com", country);
                }
            }
            //public static Usuario CreateWithDefaulCountry(string name, string email)
            //{
            //    return new Usuario(name, email, "Perú");
            //}
            //public static Usuario CreateWithDefaultEmail(string name, string country) 
            //{
            //    return new Usuario(name, name+"@outlook.com",country);
            //}
        }

        //public class UsuarioFactory
        //{   
        //    public static Usuario CreateWithDefaulCountry(string name, string email)
        //    {
        //        return new Usuario(name, email, "Perú");
        //    }
        //    public static Usuario CreateWithDefaultEmail(string name, string country)
        //    {
        //        return new Usuario(name, name + "@outlook.com", country);
        //    }
        //}

        static void Main(string[] args)
        {
            //var user = new Usuario("Henry", "henrywsr@outlook.com", "Peru");
            var user1 = Usuario.UsuarioFactory.CreateWithDefaulCountry("Henry", "henrywsr@outlook.com");
            Console.WriteLine($"Usuario: {user1.Name}, Email: {user1.Email}, Pais: {user1.Country}");
            var user2 = Usuario.UsuarioFactory.CreateWithDefaultEmail("Liz", "Venezuela");
            Console.WriteLine($"Usuario: {user2.Name}, Email: {user2.Email}, Pais: {user2.Country}");
        }
        
    }

    
}
