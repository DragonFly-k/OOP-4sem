using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2.Memento
{
    class NHist
    {public Stack<Saf> Form { get;private set; }
        public NHist()
        {
            Form = new Stack<Saf>();
        }
    }
}
