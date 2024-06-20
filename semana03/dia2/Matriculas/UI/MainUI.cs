using Matriculas.DAO;
using Matriculas.UTILS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.UI
{    
    internal class MainUI : UI
    {
        private ProfesorUI profesorUI;
        private AlumnoUI alumnoUI;

        public MainUI()
        {
            profesorUI = new ProfesorUI();
            alumnoUI = new AlumnoUI();
        }
        public override void MostrarMenu()
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                mensaje.MostrarTitulo("SISTEMA DE MATRICULAS");
                Console.WriteLine(@"
            [1] ADMINISTRACION DE PROFESORES
            [2] ADMINISTRACION DE ALUMNOS
            [3] PROCESO DE MATRICULA
            [4] REPORTES
            [5] SALIR
                ");
                mensaje.MostrarTitulo("INGRESE UNA OPCION DEL MENU:");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        //ProfesorUI profesorUI = new ProfesorUI();
                        profesorUI.MostrarMenu();
                        break;
                    case 2:
                        //AlumnoUI alumnoUI = new AlumnoUI();
                        alumnoUI.MostrarMenu();
                        break;
                    case 3:
                        //crud.ActualizarAlumno();
                        break;
                    case 4:
                        //crud.EliminarAlumno();
                        break;
                    case 5:
                        Console.WriteLine("\nSALIENDO DEL SISTEMA...");
                        //crud.GuardarAlumnos();
                        break;
                    default:
                        mensaje.MostrarMensaje("OPCION INVALIDA!!!");
                        break;
                }
            }
        }
    }
}
