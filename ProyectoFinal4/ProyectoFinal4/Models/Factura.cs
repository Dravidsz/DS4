using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal4.Models
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdUsuario { get; set; }
        public string NombreCliente { get; set; }
        public decimal Total { get; set; }
        public string Productos { get; set; }
    }

}