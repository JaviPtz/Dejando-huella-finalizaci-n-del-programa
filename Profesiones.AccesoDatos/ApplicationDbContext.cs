using Microsoft.EntityFrameworkCore;
using System;
using Profeciones.Entidad;

namespace Profesiones.AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Carpintero> Carpinteros { set;  get; }
    }
}
