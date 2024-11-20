using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8_2
{
    class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
        {

        }

        public override void CalcularIntereses()
        {
            System.Console.WriteLine(
                "CuentaCorriente.CalcularInterese() efectuado para " + "La cuenta {0}"+ getIdCuenta());
        }
    }
}
