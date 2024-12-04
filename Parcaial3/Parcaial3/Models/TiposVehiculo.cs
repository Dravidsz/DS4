using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Parcial3.Models
{
    public class TipoVehiculo
    {
        public int TipoVehiculoID { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Consumo> Consumos { get; set; }  
    }
}
