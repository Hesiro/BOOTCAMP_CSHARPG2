using OCP_Ejercicio1_Antes;

List<Person> persons = new List<Person>() { 
    new Person { FirstName = "Gabriel", LastName = "Retamozo", Role = Role.Doctor},
    new Person { FirstName = "Pepito", LastName = "Flores", Role = Role.Nurse},
    new Person { FirstName = "Juanito", LastName = "Ramos", Role = Role.None}
    };

List<Staff> staffs = new List<Staff>();
foreach(var person in persons)
{
    staffs.Add(new AccountService().Create(person));
}

foreach(var staff in staffs)
{
    Console.WriteLine($"Nombres: {staff.Firstname}, Apellidos: {staff.Lastname}, Correo: {staff.Email}");
}