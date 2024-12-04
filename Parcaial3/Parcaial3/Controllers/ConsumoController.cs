using Parcial3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parcial3.Models;

namespace Parcial3.Controllers
{
    public class ConsumoController : Controller
    {
        private readonly RegistroCombustibleContext _context;

        public ConsumoController()
        {
            _context = new RegistroCombustibleContext();
        }


        public ActionResult Index()
        {
            var consumos = _context.Consumos.Include("Estacion").Include("TipoVehiculo").Include("TipoCombustible").ToList();
            return View(consumos);
        }

        public ActionResult Reporte(int? estacionID, int? tipoVehiculoID)
        {
            var consumos = _context.Consumos.Include("Estacion")
                                            .Include("TipoVehiculo")
                                            .Include("TipoCombustible")
                                            .Where(c => (!estacionID.HasValue || c.EstacionID == estacionID) &&
                                                        (!tipoVehiculoID.HasValue || c.TipoVehiculoID == tipoVehiculoID))
                                            .ToList();
            return View(consumos);
        }
    }
}
