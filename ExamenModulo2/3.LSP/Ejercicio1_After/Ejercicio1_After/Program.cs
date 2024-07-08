namespace Ejercicio1_After
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeDepartment employee = new FullTime();
            employee.FirstName = "Gabriel";
            employee.LastName = "Retamozo";
            employee.AssignDepartment(new Department { Name = "IT" });
            employee.SetContractType(ContractType.Planilla);

            Console.Write($"{employee.FirstName} {employee.LastName} \nDepartamento: {employee.GetDepartment()} \nTipo de empleo:  {employee.ContractType}");
            Console.ReadLine();
        }
    }
}
