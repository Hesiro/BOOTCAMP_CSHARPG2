using OCP_Ejercicio1_Despues;

List<IPerson> persons = new List<IPerson>() {
    new Person {  FirstName = "Gabriel", LastName = "Retamozo"},
    new Doctor { FirstName = "Pepito", LastName = "Flores"},
    new Nurse { FirstName = "Juanitop", LastName = "Ramos"}
    };

List<Staff> staffs = new List<Staff>();
foreach (var item in persons)
{
    staffs.Add(item.IA.Create(item));
}

foreach (var staff in staffs)
{
    Console.WriteLine($"Bienvenido: {staff.FirstName} {staff.LastName} - {staff.Email}");
}