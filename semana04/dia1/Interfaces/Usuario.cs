using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Usuario : IUsuario
    {
        private string userName;
        private string password;

        public Usuario(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        public void Login(string userName, string password)
        {
            if (userName == this.userName && password == this.password)
            {
                Console.WriteLine($"Bienvenido Usuario {this.userName}.");
            }
            else
            {
                Console.WriteLine("Credenciales incorrectas");
            }
        }
    }
}
