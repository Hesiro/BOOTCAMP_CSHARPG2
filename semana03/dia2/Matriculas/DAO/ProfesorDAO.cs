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
        public override void Create()
        {
            base.mensaje.MostrarTitulo("REGISTRO DE NUEVO PROFESOR");
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
            base.mensaje.MostrarMensaje("PROFESOR REGISTRADO CON EXITO!!!");
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Read()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
