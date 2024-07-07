using Matriculas.INTERFACES;
using Matriculas.MODELS;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.DAO
{
    internal class AlumnoDAO : DAO<T>
    {
        private List<Alumno> listaAlumno = new List<Alumno>();
        private Alumno FindValue()
        {
            Console.WriteLine("INGRESE EL EMAIL DEL ALUMNO:");
            string email = Console.ReadLine();

            Alumno alumno = listaAlumno.Find(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            return alumno;
        }
        public void Create()
        {
            mensaje.MostrarTitulo("REGISTRO DE NUEVO ALUMNO");
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("NOMBRE: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("EMAIL:");
            string email = Console.ReadLine();
            Console.WriteLine("NOTA:");
            int nota = int.Parse(Console.ReadLine());


            Alumno nuevoAlumno = new Alumno(id, nombre, email, nota);
            listaAlumno.Add(nuevoAlumno);
            mensaje.MostrarMensaje("ALUMNO REGISTRADO CON EXITO!!!");
        }
        public void Read()
        {
            mensaje.MostrarTitulo("RELACION DE ALUMNOS");
            foreach (var alumno in listaAlumno)
            {
                Console.WriteLine(new string('*', 50));
                alumno.Mostrar();
            }
        }
        public void Update()
        {
            mensaje.MostrarTitulo("ACTUALIZAR ALUMNO");
            Alumno alumno = FindValue();
            if (alumno != null)
            {
                Console.WriteLine("NUEVO NOMBRE:");
                string nuevoNombre = Console.ReadLine();
                Console.WriteLine("NUEVO EMAIL:");
                string nuevoEmail = Console.ReadLine();
                Console.WriteLine("NUEVA NOTA:");
                int nuevoNota = int.Parse(Console.ReadLine());

                alumno.Nombre = nuevoNombre;
                alumno.Email = nuevoEmail; 
                alumno.Nota = nuevoNota;

                mensaje.MostrarMensaje("ALUMNO ACTUALIZADO CON EXITO !!!");
            }
            else
            {
                mensaje.MostrarMensaje("ALUMNO NO ENCONTRADO ...");
            }
        }
        public void Delete()
        {
            mensaje.MostrarTitulo("ELIMINAR ALUMNO");
            Alumno alumno = FindValue();
            if (alumno != null)
            {
                listaAlumno.Remove(alumno);
                mensaje.MostrarMensaje("ALUMNO ELIMINADO CON EXITO !!!");
            }
            else
            {
                mensaje.MostrarMensaje("ALUMNO NO ENCONTRADO ...");
            }
        }        
    }
}
