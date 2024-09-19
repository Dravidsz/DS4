using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8_8
{
    class ClaseConcreta2 : ClaseAbstracta
    {
        protected override string tomaValor()
        {
            return "Clase Concreta 2";
        }

        public override string prefixValor(string prefix)
        {
            return $"{prefix} Clase Concreta 2";
        }
    }
}
