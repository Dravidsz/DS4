using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8_9
{
     class Template : iTemplate
    {
        public void ponerVariable(string nombre, string var)
        {
            Console.WriteLine("Metodo poner Variable {nombre} : {var}");
        }

        public void verHtml(string template)
        {
            Console.WriteLine(template);    
        }
    }
}
