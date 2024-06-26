﻿using Matriculas.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UI
{
    internal class AlumnoUI : UI
    {
        private AlumnoDAO dao;
        public AlumnoUI()
        {
            dao = new AlumnoDAO();
        }
        public override void MostrarMenu()
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                mensaje.MostrarTitulo("MANTENIMIENTO DE ALUMNOS");
                Console.WriteLine(@"
            [1] REGISTAR ALUMNO
            [2] MOSTRAR ALUMNOS
            [3] ACTUALIZAR ALUMNO
            [4] ELIMINAR ALUMNO
            [5] SALIR
                ");
                mensaje.MostrarTitulo("INGRESE UNA OPCION DEL MENU:");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        dao.Create();
                        break;
                    case 2:
                        dao.Read();
                        Console.WriteLine("\n\nPRESIONE ENTER PARA CONTINUAR...");
                        Console.ReadKey();
                        break;
                    case 3:
                        dao.Update();                        
                        break;
                    case 4:
                        dao.Delete();                        
                        break;
                    case 5:
                        Console.WriteLine("\nSALIENDO DEL SISTEMA...");                        
                        break;
                    default:
                        mensaje.MostrarMensaje("\nOPCION INVALIDA!!!");
                        break;
                }
            }
        }
    }
}
