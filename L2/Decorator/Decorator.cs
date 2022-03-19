using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2.Decorator
{
    class Decorator:Account
    {
        public Decorator(Account account):base(5+account.num, account.Type, 15+account.Balance,account.OpeningDate,account.Sms,account.owner)
        {

        }
    }
}
