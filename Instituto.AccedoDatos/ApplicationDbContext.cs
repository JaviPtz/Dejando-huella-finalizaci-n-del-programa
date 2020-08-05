using Institucion.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Instituto.AccedoDatos
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appconfig.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstudianteAsignatura>()
                .ToTable("EstudianteporAsignatura")
                .HasKey(ea => new { ea.AsignaturaId, ea.EstudianteId });

            modelBuilder.Entity<Estudiante>()
                .HasKey(e => new { e.EstudianteId });
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }

        public DbSet<EstudianteAsignatura> EstudianteAsignaturas { get; set; }
    }
}
