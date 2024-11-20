using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8_8
{
    class ClaseConcreta1 : ClaseAbstracta
    {
        protected override string tomaValor()
        {
            return "Clase Concreta 1";
        }

        public override string prefixValor(string prefix)
        {
            return $"{prefix}Clase concreta 1";
        }
     
    }
}
