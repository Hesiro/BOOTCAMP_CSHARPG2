using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using CrudEmpresasPOO.Models;
using CrudEmpresasPOO.Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CrudEmpresasPOO
{
    internal class EmpresaCRUD
    {
        private List<Empresa> listaEmpresas = new List<Empresa>();
        private const string FILEPATH = "empresas.csv";
        private MensajeUI mensajeUI = new MensajeUI(50);

        public EmpresaCRUD()
        {
            try
            {
                CargarEmpresasDesdeCSV();
            }
            catch (Exception ex)
            {

                this.mensajeUI.MostrarTitulo(ex.Message);
                Console.WriteLine("\n\nPRESIONE ENTER PARA CONTINUAR...");
                Console.ReadKey();
            }
            
        }

        public void CargarEmpresasDesdeCSV()
        {
            bool conErrores = false;
            string errores = "ERRORES";
            if (File.Exists(FILEPATH))
            {
                using (StreamReader sr = new StreamReader(FILEPATH))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        try
                        {
                            listaEmpresas.Add(SepararTextoCSV(line));
                        }
                        catch (Exception ex)
                        {
                            conErrores = true;
                            errores = errores + "\n" + ex.Message;
                        }

                    }
                }

                if (conErrores) {
                    throw new ArgumentException(errores);
                }
            }
        }

        private Empresa SepararTextoCSV(string line)
        {
            string[] datos = line.Split(',');
            if (datos.Length != 3) {
                throw new ArgumentException("El formato CSV no es valido");
            }
            return new Empresa(datos[0], datos[1], datos[2]);
        }

        public void GuardarEmpresasHaciaCSV() {
            using (StreamWriter sw = new StreamWriter(FILEPATH)) {
                foreach (var empresa in listaEmpresas) { 
                    sw.WriteLine($"{empresa.Ruc},{empresa.RazonSocial},{empresa.DomicilioFiscal}");
                }
            }
        }

        private Empresa BuscarEmpresa(string ruc) {
            return listaEmpresas.Find(a => a.Ruc.Equals(ruc,StringComparison.OrdinalIgnoreCase));
        }

        public void RegistrarEmpresa()
        {
            this.mensajeUI.MostrarTitulo("REGISTRO DE NUEVA EMPRESA");
            Console.WriteLine("RUC : ");
            string? nuevoRuc = Console.ReadLine();
            Console.WriteLine("RAZON SOCIAL : ");
            string? nuevoRazonSocial = Console.ReadLine();
            Console.WriteLine("DOMICILIO FISCAL : ");
            string? nuevoDomicilioFiscal = Console.ReadLine();

            //BuscarRuc
            if (BuscarEmpresa(nuevoRuc) == null)
            {
                listaEmpresas.Add(new Empresa(nuevoRuc, nuevoRazonSocial, nuevoDomicilioFiscal));
                this.mensajeUI.MostrarMensaje("EMPRESA REGISTRADA CON EXITO!!!");
            }
            else
            {
                throw new ArgumentException($"Empresa con RUC : {nuevoRuc} ya existe!!!");
            }
            
        }

        public void MostrarEmpresas() {
            this.mensajeUI.MostrarTitulo("RELACION DE EMPRESAS");
            foreach (var empresa in listaEmpresas)
            {
                Console.WriteLine(new string('*', 50));
                Console.WriteLine(empresa.Mostrar());                
            }
        }

        public void ActualizarEmpresa()
        {
            this.mensajeUI.MostrarTitulo("ACTUALIZAR EMPRESA");
            Console.WriteLine("INGRESE EL RUC DE LA EMPRESA A ACTUALIZAR: ");
            string? actualizarRuc = Console.ReadLine();
            Empresa empresa = BuscarEmpresa(actualizarRuc);

            if (empresa != null)
            {
                Console.WriteLine("NUEVO RAZON SOCIAL: ");
                string actualizarRazonSocial = Console.ReadLine();
                Console.WriteLine("NUEVO DOMICILIO FISCAL: ");
                string actualizarDomicilioFiscal = Console.ReadLine();

                empresa.RazonSocial = actualizarRazonSocial;
                empresa.DomicilioFiscal = actualizarDomicilioFiscal;                

                this.mensajeUI.MostrarMensaje("EMPRESA ACTUALIZADO CON EXITO");
            }
            else
            {
                this.mensajeUI.MostrarMensaje("EMPRESA NO ENCONTRADO!!!");
            }
        }

        public void EliminarEmpresa()
        {
            this.mensajeUI.MostrarTitulo("ELIMINAR EMPRESA");
            Console.WriteLine("INGRESE EL RUC DE LA EMPRESA A ELIMINAR: ");
            string? eliminarRuc = Console.ReadLine();
            Empresa empresa = BuscarEmpresa(eliminarRuc);            
            if (empresa != null)
            {
                listaEmpresas.Remove(empresa);
                this.mensajeUI.MostrarMensaje("EMPRESA ELIMINADA CON EXITO!!!");
            }
            else
            {
                this.mensajeUI.MostrarMensaje("NO SE ENCONTRO LA EMPRESA...");
            }
        }

    }
}
