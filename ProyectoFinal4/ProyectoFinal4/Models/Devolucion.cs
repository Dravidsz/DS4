using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal4.Models
{


    public class Devolucion
    {
        public int IdProducto { get; set; } // Relación directa con PRODUCTO.IdProducto
        public string NombreProducto { get; set; } // Relación con PRODUCTO.Nombre
        public int Stock { get; set; } // Relación con PRODUCTO.Stock
        public int Cantidad { get; set; } // Cantidad que se devuelve
    }


}