using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8_8
{
     class ClaseAbstracta
    {
        abstract protected string tomaValor();
        abstract public string prefixValor(string prefix);

        public void printOut()
        {
            Console.WriteLine(tomaValor());
        }
    }
}
