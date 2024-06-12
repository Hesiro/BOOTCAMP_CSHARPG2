List<Dictionary<string, string>> listaAlumnos = new List<Dictionary<string, string>>();
Dictionary<string, string> alumnomuestra = new Dictionary<string, string> {
    {"Nombre","César Mayta" },
    {"email", "cesar@gmail.com" },
    {"celular","992923526" }
};
listaAlumnos.Add(alumnomuestra);

int opcion = 0;
const int ANCHO = 50;

while (opcion != 5)
{
    Console.Clear();
    Console.WriteLine(new string('=', ANCHO));
    Console.WriteLine(new string(' ', 20) + "CRUD DE ALUMNOS");
    Console.WriteLine(new string('=', ANCHO));
    Console.WriteLine(@"
[1] REGISTRAR ALUMNO
[2] MOSTRAR ALUMNOS
[3] ACTUALIZAR ALUMNO
[4] ELIMINAR ALUMNO
[5] SALIR
");
    Console.WriteLine(new string('=', ANCHO));
    Console.WriteLine("INGRESE UNA OPCION DEL MENU:");
    opcion = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcion)
    {
        case 1:
            MostrarTitulo("[2] REGISTRAR ALUMNO");
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Celular:");
            string celular = Console.ReadLine();

            Dictionary<string, string> nuevoAlumno = new Dictionary<string, string>{
                    {"Nombre",nombre },
                    {"email", email },
                    {"celular",celular }
            };
            listaAlumnos.Add(nuevoAlumno);
            Console.Clear();
            MostrarTitulo("ALUMNO REGISTRADO CON EXITO...");
            System.Threading.Thread.Sleep(1000);
            break;
        case 2:
            MostrarTitulo("[2] MOSTRAR ALUMNOS");
            foreach (var alumno in listaAlumnos)
            {
                Console.WriteLine(new string('*', ANCHO));
                foreach (var dicAlumno in alumno)
                {
                    Console.WriteLine($"{dicAlumno.Key} : {dicAlumno.Value}");
                }
            }
            MostrarTitulo("PRESIONE UNA TECLA PARA CONTINUAR...");
            Console.ReadLine();
            break;
        case 3:
            MostrarTitulo("[3] ACTUALIZAR ALUMNO");
            Console.WriteLine("Ingrese el email del alumno a actualizar:");
            string emailBusqueda = Console.ReadLine();
            int posicionActualizar = listaAlumnos.FindIndex(a => a["email"] == emailBusqueda);
            if(posicionActualizar == -1)
            {
                Console.Clear() ;
                MostrarTitulo("NO SE ENCONTRO ALUMNO");
            }
            else
            {
                Console.WriteLine($"Alumno a actualizar : {listaAlumnos[posicionActualizar]["Nombre"]}");
                Console.WriteLine("INGRESE NUEVOS DATOS PARA EL ALUMNO");
                Console.WriteLine("PRESIONE ENTER SI NO DESEA ACTUALIZAR DATO...");
                Console.WriteLine($"NOMBRE {listaAlumnos[posicionActualizar]["Nombre"]}");
                string nombreActualizar = Console.ReadLine();
                if (string.IsNullOrEmpty(nombreActualizar)) nombreActualizar = listaAlumnos[posicionActualizar]["Nombre"];

                Console.WriteLine($"EMAIL {listaAlumnos[posicionActualizar]["email"]}");
                string emailActualizar = Console.ReadLine();
                if (string.IsNullOrEmpty(emailActualizar)) emailActualizar = listaAlumnos[posicionActualizar]["email"];

                Console.WriteLine($"CELULAR {listaAlumnos[posicionActualizar]["celular"]}");
                string celularActualizar = Console.ReadLine();
                if (string.IsNullOrEmpty(celularActualizar)) celularActualizar = listaAlumnos[posicionActualizar]["celular"];

                listaAlumnos[posicionActualizar] = new Dictionary<string, string> {
                    {"Nombre" , nombreActualizar },
                    {"email" , emailActualizar },
                    {"celular",celularActualizar}
                };

                MostrarTitulo("ALUMNO ACTUALIZADO CON EXITO...");
                System.Threading.Thread.Sleep(1000);
            }            
            break;
        case 4:
            MostrarTitulo("[3] ELIMINAR ALUMNO");
            Console.WriteLine("Ingrese el email del alumno a eliminar:");
            string emailEliminar = Console.ReadLine();
            int posicionEliminar = listaAlumnos.FindIndex(a => a["email"] == emailEliminar);
            if (posicionEliminar == -1)
            {
                Console.Clear();
                MostrarTitulo("NO SE ENCONTRO ALUMNO");
            }
            else
            {
                listaAlumnos.RemoveAt(posicionEliminar);
                MostrarTitulo("ALUMNO ELIMINADO CON EXITO...");
                System.Threading.Thread.Sleep(1000);
            }
            break;
        case 5:
            MostrarTitulo("SALIENDO DEL SISTEMA...");
            break;
        default:
            MostrarTitulo("OPCION NO VALIDA");
            System.Threading.Thread.Sleep(1000);
            break;
    }
}

void MostrarTitulo(string titulo)
{
    Console.WriteLine(new string('=', ANCHO));
    Console.WriteLine(new string(' ', 15) + titulo);
    Console.WriteLine(new string('=', ANCHO));
}

/*TAREA
 HACER IGUALIRO DE EMPRESA
ID AUTOINCREMENTAL
RUC
RAZON SOCIAL
DOMICILIO FISCAL
 */