using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Administrador : IUsuario
    {

        private string userName;
        private string password;

        public Administrador()
        {
            userName = "admin";
            password = "1234";
        }

        public void Login(string userName, string password)
        {
            if (userName == this.userName && password == this.password)
            {
                Console.WriteLine($"Bienvenido Administrador {this.userName}.");
            }
            else
            {
                Console.WriteLine("Credenciales incorrectas");
            }
        }
    }
}
