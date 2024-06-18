using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAlumnosPOO
{
    internal class AlumnoCRUD
    {
        private List<Alumno> listaAlumnos = new List<Alumno>();
        private MensajeUI mensajeUI = new MensajeUI(50);
        private string filePath = "alumnos.csv";

        public AlumnoCRUD()
        {
            //Alumno alumnoMuestra = new Alumno ("Henry Williams","henrywsr@outlook.com","996 675 085" );
            //ListaAlumnos.Add( alumnoMuestra );
            this.CargarAlumnos();
        }

        public void MostrarAlumnos()
        {
            this.mensajeUI.MostrarTitulo("RELACION DE ALUMNOS");            
            foreach (var alumno in listaAlumnos)
            {
                Console.WriteLine(new string('*', 50));
                alumno.Mostrar();
            }
        }

        public void RegistrarAlumno()
        {
            this.mensajeUI.MostrarTitulo("REGISTRO DE NUEVO ALUMNO");            
            Console.WriteLine("NOMBRE : ");
            string nombre = Console.ReadLine();
            Console.WriteLine("EMAIL : ");
            string email = Console.ReadLine();
            Console.WriteLine("CELULAR : ");
            string celular = Console.ReadLine();

            Alumno nuevoAlumno = new Alumno(nombre, email, celular);
            listaAlumnos.Add(nuevoAlumno);
            this.mensajeUI.MostrarMensaje("ALUMNO REGISTRADO CON EXITO!!!");
        }

        public void ActualizarAlumno()
        {
            Alumno alumno = this.BuscarAlumno("ACTUALIZAR");

            if (alumno != null) 
            {
                Console.WriteLine("NUEVO NOMBRE : ");
                string nuevoNombre = Console.ReadLine();
                Console.WriteLine("NUEVO EMAIL : ");
                string nuevoEmail = Console.ReadLine();
                Console.WriteLine("NUEVO CELULAR : ");
                string nuevoCelular = Console.ReadLine();

                alumno.Nombre = nuevoNombre;
                alumno.Email = nuevoEmail;
                alumno.Celular = nuevoCelular;

                this.mensajeUI.MostrarMensaje("ALUMNO ACTUALIZADO CON EXITO");
            }
            else
            {
                this.mensajeUI.MostrarMensaje("ALUMNO NO ENCONTRADO!!!");
            }
        }

        public void EliminarAlumno()
        {
            Alumno alumno = this.BuscarAlumno("ELIMINAR");
            if (alumno != null) { 
                listaAlumnos.Remove(alumno);
                this.mensajeUI.MostrarMensaje("ALUMNO ELIMINADO CON EXITO!!!");
            }
            else
            {
                this.mensajeUI.MostrarMensaje("NO SE ENCONTRO EL ALUMNO...");
            }

        }
        private Alumno BuscarAlumno(string opcion)
        {
            Console.WriteLine($"{opcion} ALUMNO");
            Console.WriteLine($"INGRESE EL EMAIL DEL ALUMNO A {opcion} : ");
                        
            string? email = Console.ReadLine();

            return listaAlumnos.Find(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public void CargarAlumnos()
        {
            if (File.Exists(filePath)) {
                using (StreamReader sr = new StreamReader(filePath)) {
                    string? line;
                    while ((line = sr.ReadLine()) != null) {
                        listaAlumnos.Add(Alumno.FromCsv(line));
                    }
                }
            }
        }

        public void GuardarAlumnos() {
            using (StreamWriter sr = new StreamWriter(filePath)) {
                foreach (var alumno in listaAlumnos)
                {
                    sr.WriteLine(alumno.ToCsv());
                }
            }
        }
    }
}