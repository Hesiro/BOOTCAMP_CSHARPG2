﻿using Matriculas.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.DAO
{
    internal class AlumnoDAO : DAO
    {
        private List<Alumno> listaAlumno = new List<Alumno>();
        private Alumno FindValue()
        {
            Console.WriteLine("INGRESE EL EMAIL DEL ALUMNO:");
            string email = Console.ReadLine();

            Alumno alumno = listaAlumno.Find(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            return alumno;
        }
        public override void Create()
        {
            mensaje.MostrarTitulo("REGISTRO DE NUEVO ALUMNO");
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("NOMBRE: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("EMAIL:");
            string email = Console.ReadLine();
            

            Alumno nuevoAlumno = new Alumno(id, nombre, email);
            listaAlumno.Add(nuevoAlumno);
            mensaje.MostrarMensaje("ALUMNO REGISTRADO CON EXITO!!!");
        }
        public override void Read()
        {
            mensaje.MostrarTitulo("RELACION DE ALUMNOS");
            foreach (var alumno in listaAlumno)
            {
                Console.WriteLine(new string('*', 50));
                alumno.Mostrar();
            }
        }
        public override void Update()
        {
            mensaje.MostrarTitulo("ACTUALIZAR ALUMNO");
            Alumno alumno = FindValue();
            if (alumno != null)
            {
                Console.WriteLine("NUEVO NOMBRE:");
                string nuevoNombre = Console.ReadLine();
                Console.WriteLine("NUEVO EMAIL:");
                string nuevoEmail = Console.ReadLine();                

                alumno.Nombre = nuevoNombre;
                alumno.Email = nuevoEmail;                

                mensaje.MostrarMensaje("ALUMNO ACTUALIZADO CON EXITO !!!");
            }
            else
            {
                mensaje.MostrarMensaje("ALUMNO NO ENCONTRADO ...");
            }
        }
        public override void Delete()
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