using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    public interface IEmployee
    {
        string FirstName {  get; set; }
        string LastName { get; set; }
        ContractType ContractType { get; set; }
        public void SetContractType(ContractType contractType);
    }
}
