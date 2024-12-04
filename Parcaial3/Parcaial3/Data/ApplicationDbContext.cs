using Microsoft.EntityFrameworkCore;
using Parcial3.Models;
using System.Collections.Generic;
using System;
using System.Data.Entity;

namespace Parcial3.Data
{
    public class RegistroCombustibleContext : DbContext
    {
        public RegistroCombustibleContext() : base("name=RegistroCombustibleDB") { }

        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Estacion> Estaciones { get; set; }
        public DbSet<TipoVehiculo> TiposVehiculos { get; set; }
        public DbSet<TipoCombustible> TiposCombustibles { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
    }
}
