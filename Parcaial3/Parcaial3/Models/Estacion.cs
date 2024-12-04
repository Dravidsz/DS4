using System.Collections.Generic;

namespace Parcial3.Models
{
    public class Estacion
    {
        public int EstacionID { get; set; }
        public string Nombre { get; set; }
        public int CiudadID { get; set; } 

        public virtual Ciudad Ciudad { get; set; }  
        public virtual ICollection<Consumo> Consumos { get; set; }  
    }
}
