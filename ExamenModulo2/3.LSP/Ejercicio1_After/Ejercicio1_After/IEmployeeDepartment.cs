using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    public interface IEmployeeDepartment: IEmployee
    {
        Department Department { get; set; }
        string GetDepartment();
        void AssignDepartment(Department department);
    }
}
