﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Ejercicio1_Despues
{
    public class AccountNurse : IAcountService
    {
        public Staff Create(IPerson Iperson)
        {
            Staff staff = new Staff();
            staff.FirstName = Iperson.FirstName;
            staff.LastName = Iperson.LastName;
            staff.Email = $"{Iperson.FirstName}.{Iperson.LastName}@nurse.com";
            return staff;
        }
    }
}
