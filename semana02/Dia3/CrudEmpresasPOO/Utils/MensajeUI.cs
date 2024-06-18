using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEmpresasPOO.Utils
{
    internal class MensajeUI
    {
        private int ancho;
        public MensajeUI(int ancho)
        {
            this.ancho = ancho;
        }

        public void MostrarTitulo(string titulo)
        {
            Console.WriteLine(new string('=', ancho));
            Console.WriteLine(new string(' ', Espaciado(titulo.Length)) + titulo);
            Console.WriteLine(new string('=', ancho));
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(new string('.', ancho));
            Console.WriteLine(new string(' ', Espaciado(mensaje.Length)) + mensaje);
            Console.WriteLine(new string('.', ancho));
            Thread.Sleep(1000);
        }

        private int Espaciado(int tam)
        {
            if (tam >= ancho)
                return 0;
            else
                return (ancho - tam) / 2;
        }
    }
}
