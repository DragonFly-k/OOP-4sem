using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2.Memento
{
    public class Saf
    {
        public List<Account> accounts { get; set; }
        public Saf(ref List<Account> accounts)
        {
            this.accounts = accounts;
        }
    }
}
