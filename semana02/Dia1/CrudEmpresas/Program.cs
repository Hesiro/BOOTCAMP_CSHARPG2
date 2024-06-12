const string ENC_RUC = "Ruc";
const string ENC_RAZON_SOCIAL = "Razón Social";
const string ENC_DOMICILIO_FISCAL = "Domicilio Fiscal";
List<Dictionary<string, string>> listaEmpresas = new List<Dictionary<string, string>>();
int opcion = 0;
string? captura = "";
const int ANCHO = 40;

CargarDatosIniciales();
while (opcion != 5)
{
    Console.Clear();
    Console.WriteLine(new string('+', ANCHO));
    Console.WriteLine(new string(' ', 15) + "CRUD EMPRESAS");
    Console.WriteLine(new string('+', ANCHO));
    Console.WriteLine("[1] REGISTRAR EMPRESA");
    Console.WriteLine("[2] MOSTRAR EMPRESAS");
    Console.WriteLine("[3] ACTUALIZAR EMPRESA");
    Console.WriteLine("[4] ELIMINAR EMPRESA");
    Console.WriteLine("[5] SALIR");

    MostrarMensaje("ELIJA UNA OPCION");

    captura = Console.ReadLine();
    if (captura == null)
        opcion = 0;
    else
        if (!int.TryParse(captura, out opcion))
        opcion = 0;

    Console.Clear();
    switch (opcion)
    {
        case 1:            
            RegistrarEmpresa();
            break;
        case 2:            
            MostrarEmpresas();
            break;
        case 3:
            ActualizarEmpresa();
            break;
        case 4:
            EliminarEmpresa();
            break;
        case 5:
            MostrarTitulo("[5] SALIR DEL SISTEMA");
            break;
        default:
            MostrarTitulo("SELECCION NO VALIDA");
            MostrarMensaje("ENTER PARA CONTINUAR...");
            Console.ReadLine();
            break;
    }
}

//FUNCIONES Y PROCEDIMIENTOS
void CargarDatosIniciales()
{
    //Buenos contribuyentes
    listaEmpresas.Add(new Dictionary<string, string> {
        { ENC_RUC, "20542245671"},
        { ENC_RAZON_SOCIAL, "SELVA INDUSTRIAS MELITA E.I.R.L."},
        { ENC_DOMICILIO_FISCAL,""}
    });
    listaEmpresas.Add(new Dictionary<string, string> {
        { ENC_RUC, "20604895988"},
        { ENC_RAZON_SOCIAL, "AGRICOLA Y SERVICIOS GENERALES COROCAS SOCIEDAD COMERCIAL DE RESPONSABILIDAD LIMITADA"},
        { ENC_DOMICILIO_FISCAL,""}
    });
    listaEmpresas.Add(new Dictionary<string, string> {
        { ENC_RUC, "20602945589"},
        { ENC_RAZON_SOCIAL, "AGRINOVA DEL PERU S.R.L"},
        { ENC_DOMICILIO_FISCAL,""}
    });
    listaEmpresas.Add(new Dictionary<string, string> {
        { ENC_RUC, "20568242271"},
        { ENC_RAZON_SOCIAL, "AGROSORIA E.I.R.L"},
        { ENC_DOMICILIO_FISCAL,""}
    });
    listaEmpresas.Add(new Dictionary<string, string> {
        { ENC_RUC, "20570892291"},
        { ENC_RAZON_SOCIAL, "ALFARO & CONTADORES SOCIEDAD ANONIMA CERRADA"},
        { ENC_DOMICILIO_FISCAL,""}
    });
}

void MostrarTitulo(string titulo)
{
    Console.WriteLine(new string('+', ANCHO));
    Console.WriteLine(new string(' ', 10) + titulo);
    Console.WriteLine(new string('+', ANCHO));
}

void MostrarMensaje(string mensaje)
{
    Console.WriteLine();
    Console.WriteLine(new string('-', ANCHO));
    Console.WriteLine(new string(' ', 10) + mensaje);    
}

void RegistrarEmpresa()
{
    MostrarTitulo("[1] REGISTRAR EMPRESA");
    Console.WriteLine($"{ENC_RUC} : ");
    string? nuevoRuc = Console.ReadLine();
    Console.WriteLine($"{ENC_RAZON_SOCIAL} : ");
    string? nuevoRazonSocial = Console.ReadLine();
    Console.WriteLine($"{ENC_DOMICILIO_FISCAL} : ");
    string? nuevoDomicilioFiscal = Console.ReadLine();

    int buscarNuevo = listaEmpresas.FindIndex( a => a[ENC_RUC] == nuevoRuc);
    if (buscarNuevo == -1)
    {
        listaEmpresas.Add(new Dictionary<string, string>
        {
            { ENC_RUC, nuevoRuc },
            { ENC_RAZON_SOCIAL, nuevoRazonSocial },
            { ENC_DOMICILIO_FISCAL, nuevoDomicilioFiscal }
        });
        MostrarMensaje("EMPRESA REGISTRADO CON EXITO");
        MostrarMensaje("ENTER PARA CONTINUAR...");
        Console.ReadLine();
    }
    else
    {
        MostrarMensaje($"REGISTRO {ENC_RUC} : {nuevoRuc} YA EXISTE");
        MostrarMensaje("ENTER PARA CONTINUAR...");
        Console.ReadLine();
    }
}

void MostrarEmpresas()
{
    MostrarTitulo("[2] MOSTRAR EMPRESAS");
    foreach (var empresa in listaEmpresas)
    {
        Console.WriteLine(new string('.',ANCHO));
        foreach (var dicEmpresa in empresa)
        {
            Console.WriteLine($"{dicEmpresa.Key} : \t{dicEmpresa.Value}");
        }
    }
    MostrarMensaje("ENTER PARA CONTINUAR...");
    Console.ReadLine();
}

void ActualizarEmpresa()
{
    MostrarTitulo("[3] ACTUALIZAR EMPRESA");
    Console.WriteLine($"INGRESE \"{ENC_RUC}\" A ACTUALIZAR : ");
    string? actualizarRuc = Console.ReadLine();
    int buscarActualizar = listaEmpresas.FindIndex(a => a[ENC_RUC] == actualizarRuc);
    if( buscarActualizar == -1)
    {
        MostrarMensaje($"NO SE ENCONTRO EMPRESA CON {ENC_RUC} : {actualizarRuc}");
    }
    else
    {
        Console.WriteLine($"EMPRESA A ACTUALIZAR : {listaEmpresas[buscarActualizar][ENC_RUC]} - {listaEmpresas[buscarActualizar][ENC_RAZON_SOCIAL]}");
        Console.WriteLine("INGRESE NUEVOS DATOS PARA LA EMPRESA");
        Console.WriteLine("PRESIONE ENTER SI NO DESEA ACTUALIZAR DATO...");

        Console.WriteLine($"{ENC_RUC} {listaEmpresas[buscarActualizar][ENC_RUC]}");
        string? rucActualizar = Console.ReadLine();
        if (string.IsNullOrEmpty(rucActualizar)) rucActualizar = listaEmpresas[buscarActualizar][ENC_RUC];

        Console.WriteLine($"{ENC_RAZON_SOCIAL} {listaEmpresas[buscarActualizar][ENC_RAZON_SOCIAL]}");
        string? razonSocialActualizar = Console.ReadLine();
        if (string.IsNullOrEmpty(razonSocialActualizar)) razonSocialActualizar = listaEmpresas[buscarActualizar][ENC_RAZON_SOCIAL];

        Console.WriteLine($"{ENC_DOMICILIO_FISCAL} {listaEmpresas[buscarActualizar][ENC_DOMICILIO_FISCAL]}");
        string? domicilioFiscalActualizar = Console.ReadLine();
        if (string.IsNullOrEmpty(domicilioFiscalActualizar)) domicilioFiscalActualizar = listaEmpresas[buscarActualizar][ENC_DOMICILIO_FISCAL];

        listaEmpresas[buscarActualizar] = new Dictionary<string, string> {
            {ENC_RUC, rucActualizar },
            {ENC_RAZON_SOCIAL, razonSocialActualizar },
            {ENC_DOMICILIO_FISCAL, domicilioFiscalActualizar }
        };
        MostrarMensaje("EMPRESA ACTUALIZADA");
    }
    MostrarMensaje("ENTER PARA CONTINUAR...");
    Console.ReadLine();
}

void EliminarEmpresa() 
{
    MostrarTitulo("[4] ELIMINAR EMPRESA");
    Console.WriteLine($"INGRESE \"{ENC_RUC}\" A ELIMINAR : ");
    string? eliminarRuc = Console.ReadLine();
    int buscarEliminar = listaEmpresas.FindIndex(a => a[ENC_RUC] == eliminarRuc);
    if (buscarEliminar == -1) 
    {
        MostrarMensaje($"NO SE ENCONTRO EMPRESA CON {ENC_RUC} : {eliminarRuc}");
    }
    else
    {
        listaEmpresas.RemoveAt( buscarEliminar );
        MostrarMensaje("EMPRESA ELIMINADA");
    }
    MostrarMensaje("ENTER PARA CONTINUAR...");
    Console.ReadLine();
}