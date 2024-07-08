using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    internal class FullTime : Employee, IEmployeeDepartment
    {
        public Department Department { get ; set ; }

        public void AssignDepartment(Department department)
        {
            Department = department;
        }

        public string GetDepartment()
        {
            return Department.Name;
        }

        public string GetSalarioFijo()
        {
            string salario = "";
            if (string.IsNullOrEmpty(Department.Name))
            {
                new NotImplementedException("Al asignar un departamento, tiene que enviar un departamento valido");
            }
            else
            {
                salario = "5000";
            }
            return salario;

        }
    }
}
