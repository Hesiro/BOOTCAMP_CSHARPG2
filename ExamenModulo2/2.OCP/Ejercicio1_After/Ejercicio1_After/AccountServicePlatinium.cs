using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    public class AccountServicePlatinium : IAccountService
    {
        public Membership Create(IPerson IPerson)
        {
            Membership membership = new Membership();
            membership.FirstName = IPerson.FirstName;
            membership.LastName = IPerson.LastName;
            membership.Email = $"{IPerson.FirstName}.{IPerson.LastName}@platinium.com";
            membership.Id = Guid.NewGuid().ToString();
            membership.Price = 50;
            return membership;
        }
    }
}
