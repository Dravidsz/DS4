using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Parcial3.Models
{
    public class TipoCombustible
    {
        public int TipoCombustibleID { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Consumo> Consumos { get; set; }  
    }
}

