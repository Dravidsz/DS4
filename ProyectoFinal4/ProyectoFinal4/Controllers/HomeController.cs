using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using ProyectoFinal4.Models;

namespace ProyectoFinal4.Controllers
{
    public class HomeController : Controller
    {
        static string cadena = "Data Source=DESKTOP-61HODJ5; Initial Catalog=DB_ACCESO; Integrated Security=true";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inventario()
        {
            List<Producto> productos = null;

            if (Request.HttpMethod == "POST")
            {
                using (SqlConnection cn = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ObtenerProductos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        cn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        productos = new List<Producto>();
                        while (reader.Read())
                        {
                            Producto producto = new Producto()
                            {
                                IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                Stock = Convert.ToInt32(reader["Stock"])
                            };

                            productos.Add(producto);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Message = "Error al obtener los productos: " + ex.Message;
                    }
                }
            }

            return View(productos);
        }

        public ActionResult IngresarProducto()
        {
            ViewBag.Message = "Ingresar Productos";
            return View();
        }

        [HttpPost]
        public ActionResult IngresarProducto(Producto producto)
        {
            if (ModelState.IsValid)
            {
                string mensaje = string.Empty;

                using (SqlConnection cn = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("InsertarProducto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Stock", producto.Stock);

                    try
                    {
                        cn.Open();
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            mensaje = "Producto ingresado correctamente.";
                        }
                        else
                        {
                            mensaje = "No se pudo insertar el producto.";
                        }
                    }
                    catch (Exception ex)
                    {
                        mensaje = "Error al insertar el producto: " + ex.Message;
                    }
                }

                ViewBag.Message = mensaje;
            }

            return View(producto);
        }

        public ActionResult Devolucion()
        {
            List<Devolucion> devoluciones = new List<Devolucion>();

            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("SELECT IdProducto, Nombre, Stock FROM PRODUCTO", cn);

                try
                {
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Devolucion devolucion = new Devolucion()
                        {
                            IdProducto = Convert.ToInt32(reader["IdProducto"]),
                            NombreProducto = reader["Nombre"].ToString(),
                            Stock = Convert.ToInt32(reader["Stock"]),
                            Cantidad = 0
                        };

                        devoluciones.Add(devolucion);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Error al obtener los productos: " + ex.Message;
                }
            }

            return View(devoluciones);
        }

        [HttpPost]
        public ActionResult Devolucion(List<Devolucion> devoluciones)
        {
            if (devoluciones == null || devoluciones.Any(d => d.Cantidad <= 0))
            {
                ViewBag.Message = "La cantidad debe ser mayor que 0 para la devolución.";
                return View(devoluciones);
            }

            string mensaje = string.Empty;

            foreach (var devolucion in devoluciones)
            {
                using (SqlConnection cn = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_DevolucionProducto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdProducto", devolucion.IdProducto);
                    cmd.Parameters.AddWithValue("@Cantidad", devolucion.Cantidad);

                    SqlParameter outputParam = new SqlParameter("@Mensaje", SqlDbType.VarChar, 100)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();

                        mensaje = outputParam.Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        mensaje = "Error al procesar la devolución: " + ex.Message;
                    }
                }
            }

            ViewBag.Message = mensaje;
            return View(devoluciones);
        }
    }
}
