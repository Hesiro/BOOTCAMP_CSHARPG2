namespace DIP_Ejercicio1_BEFORE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ Name="",Gender= Gender.Male, Role = Role.Manager },
                new Employee{ Name="",Gender= Gender.Male, Role = Role.Manager },
                new Employee{ Name="",Gender= Gender.Male, Role = Role.Manager },
                new Employee{ Name="",Gender= Gender.Male, Role = Role.Manager }
            };

            EmployeeManager employeeManager = new EmployeeManager();
            foreach (Employee employee in employees)
            {
                employeeManager.Save(employee);
            }

            EmployeeSearch employeeSearch = new EmployeeSearch(employeeManager);
            Console.WriteLine(employeeSearch.GetMaleExecutives().ToString());
        }
    }
}
