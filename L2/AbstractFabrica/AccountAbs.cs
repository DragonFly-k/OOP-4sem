using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2.AbstractFabrica
{
    public class AccountAbs
    {
        private Abstract acc;

        public AccountAbs(AbstractFactory factory)
        {
            acc = factory.CreateOwner();
        }
    }
}
