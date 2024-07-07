using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Ejercicio1_Antes
{
    public class AccountService
    {
        public Staff Create(Person person)
        {
            Staff staff = new Staff();
            staff.Firstname = person.FirstName;
            staff.Lastname = person.LastName;
            staff.Role = person.Role;
            switch (person.Role)
            {
                case Role.Doctor:
                    staff.Email = $"{person.FirstName}.{person.LastName}@doctor.com";
                    break;
                case Role.Nurse:
                    staff.Email = $"{person.FirstName}.{person.LastName}@nurse.com";
                    break;
                case Role.None:
                    staff.Email = $"{person.FirstName}.{person.LastName}@staff.com";
                    break;
            }
            //staff.Email = $"{person.FirstName}.{person.LastName}@staff.com";
            return staff;
        }
    }
}
