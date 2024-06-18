﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAlumnosPOO
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
            Console.WriteLine(new string('=',this.ancho));
            Console.WriteLine(new string(' ', 15) + titulo);
            Console.WriteLine(new string('=', this.ancho));
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(new string('.', this.ancho));
            Console.WriteLine(new string(' ', 15) + mensaje);
            Console.WriteLine(new string('.', this.ancho));
            System.Threading.Thread.Sleep(1000);
        }
    }
}
