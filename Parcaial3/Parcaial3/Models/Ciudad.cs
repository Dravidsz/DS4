using System.Collections.Generic;

namespace Parcial3.Models
{
    public class Ciudad
    {
        public int CiudadID { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Estacion> Estaciones { get; set; }  
    }
}
