using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial3.Models
{
    public class Consumo
    {
        public int ConsumoID { get; set; }
        public int EstacionID { get; set; }  
        public int TipoVehiculoID { get; set; }  
        public int TipoCombustibleID { get; set; }  
        public decimal Litros { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Estacion Estacion { get; set; }
        public virtual TipoVehiculo TipoVehiculo { get; set; }
        public virtual TipoCombustible TipoCombustible { get; set; }
    }
}
