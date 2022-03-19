using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    internal class Singleton
    {
        private static Singleton settings;
        private Singleton(Form1 form)
        {
            form.BackColor = System.Drawing.Color.LemonChiffon;
            form.Text = "Дурдом";
        }
        public static Singleton GetSettings(Form1 form)
        {
            if (settings == null)
            {
                settings = new Singleton(form);
            }
            return settings;
        }
    }
}
