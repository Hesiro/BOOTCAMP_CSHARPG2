﻿using Matriculas.DAO;
using Matriculas.UTILS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UI
{
    internal abstract class UI
    {
        const int ANCHO = 50;
        protected Mensaje mensaje = new Mensaje(50);
        public abstract void MostrarMenu();
        
    }
}
