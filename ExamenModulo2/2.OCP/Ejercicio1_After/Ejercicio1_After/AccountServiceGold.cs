using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    public class AccountServiceGold: IAccountService
    {
        public Membership Create(IPerson IPerson)
        {
            Membership membership = new Membership();
            membership.FirstName = IPerson.FirstName;
            membership.LastName = IPerson.LastName;
            membership.Email = $"{IPerson.FirstName}.{IPerson.LastName}@gold.com";
            membership.Id = Guid.NewGuid().ToString();
            membership.Price = 40;
            return membership;
        }
    }
}
