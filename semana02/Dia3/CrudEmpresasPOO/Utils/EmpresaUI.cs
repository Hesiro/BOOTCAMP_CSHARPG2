using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEmpresasPOO.Utils
{
    internal class EmpresaUI
    {
        const int ANCHO = 50;
        private EmpresaCRUD crud;
        private MensajeUI mensajeUI = new MensajeUI(ANCHO);

        public EmpresaUI()
        {
            crud = new EmpresaCRUD();
        }

        public void MostrarMenuPrincipal()
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.Clear();
                mensajeUI.MostrarTitulo("CRUD DE EMPRESAS");
                Console.WriteLine(@"
            [1] REGISTAR EMPRESA
            [2] MOSTRAR EMPRESAS
            [3] ACTUALIZAR EMPRESA
            [4] ELIMINAR EMPRESA
            [5] SALIR
                ");

                mensajeUI.MostrarTitulo("INGRESE UNA OPCION DEL MENU:");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        try
                        {
                            crud.RegistrarEmpresa();
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("\n\nPRESIONE ENTER PARA CONTINUAR...");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        crud.MostrarEmpresas();
                        Console.WriteLine("\n\nPRESIONE ENTER PARA CONTINUAR...");
                        Console.ReadKey();
                        break;
                    case 3:
                        crud.ActualizarEmpresa();
                        break;
                    case 4:
                        crud.EliminarEmpresa();
                        break;
                    case 5:
                        Console.WriteLine("SALIENDO DEL SISTEMA...");
                        crud.GuardarEmpresasHaciaCSV();
                        break;
                    default:
                        mensajeUI.MostrarMensaje("OPCION INVALIDA!!!");
                        break;
                }
            }
        }

    }
}
