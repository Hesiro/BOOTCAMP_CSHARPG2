﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    public class Employee : IEmployee
    {
        public string FirstName { get; set ; }
        public string LastName { get; set; }
        public ContractType ContractType { get; set; }

        public void SetContractType(ContractType contractType)
        {
            ContractType = contractType;
        }
    }
}
