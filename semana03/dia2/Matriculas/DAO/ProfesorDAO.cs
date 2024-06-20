using Matriculas.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.DAO
{
    internal class ProfesorDAO : DAO
    {
        private List<Profesor> listaProfesor = new List<Profesor>();

        private Profesor FindValue()
        {
            Console.WriteLine("INGRESE EL EMAIL DEL PROFESOR:");
            string email = Console.ReadLine();

            Profesor profesor = listaProfesor.Find(a => a.Email.Equals(email,StringComparison.OrdinalIgnoreCase));
            return profesor;
        }
        public override void Create()
        {
            mensaje.MostrarTitulo("REGISTRO DE NUEVO PROFESOR");
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("NOMBRE: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("EMAIL:");
            string email = Console.ReadLine();
            Console.WriteLine("ESPECIALIDAD:");
            string especialidad = Console.ReadLine();

            Profesor nuevoProfesor = new Profesor(id, nombre, email, especialidad);
            listaProfesor.Add(nuevoProfesor);
            mensaje.MostrarMensaje("PROFESOR REGISTRADO CON EXITO!!!");
        }
        public override void Read()
        {
            mensaje.MostrarTitulo("RELACION DE PROFESORES");
            foreach (var profesor in listaProfesor)
            {
                Console.WriteLine(new string('*', 50));
                profesor.Mostrar();
            }
        }
        public override void Update()
        {
            mensaje.MostrarTitulo("ACTUALIZAR PROFESOR");
            Profesor profesor = FindValue();
            if (profesor != null)
            {
                Console.WriteLine("NUEVO NOMBRE:");
                string nuevoNombre = Console.ReadLine();
                Console.WriteLine("NUEVO EMAIL:");
                string nuevoEmail = Console.ReadLine();
                Console.WriteLine("NUEVO ESPECIALIDAD:");
                string nuevoEspecialidad = Console.ReadLine();

                profesor.Nombre = nuevoNombre;
                profesor.Email = nuevoEmail;
                profesor.Especialidad = nuevoEspecialidad;

                mensaje.MostrarMensaje("PROFESOR ACTUALIZADO CON EXITO !!!");
            }
            else {
                mensaje.MostrarMensaje("PROFESOR NO ENCONTRADO ...");
            }
        }
        public override void Delete()
        {
            mensaje.MostrarTitulo("ELIMINAR PROFESOR");
            Profesor profesor = FindValue();
            if (profesor != null)
            {
                listaProfesor.Remove(profesor);
                mensaje.MostrarMensaje("PROFESOR ELIMINADO CON EXITO !!!");
            }
            else
            {
                mensaje.MostrarMensaje("PROFESOR NO ENCONTRADO ...");
            }
        }
    }
}
