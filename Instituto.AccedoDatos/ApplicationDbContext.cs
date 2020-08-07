using Institucion.Negocio;
using Instituto.Entidad;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Instituto.AccedoDatos
{
    public class ApplicationDbContext : DbContext
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
                .HasKey(ea => new { ea.IdAsignatura, ea.IdEstudiante });

            modelBuilder.Entity<ProfesorAsignatura>()
                .ToTable("ProfesorporAsignatura")
                .HasKey(pa => new { pa.IdAsignatura, pa.IdProfesor });

            modelBuilder.Entity<Profesor>()
                .HasKey(p => new { p.IdProfesor });

            modelBuilder.Entity<Estudiante>()
                .HasKey(e => new { e.IdEstudiante });

            modelBuilder.Entity<Curso>()
                .HasKey(c => new { c.IdCurso });

            modelBuilder.Entity<Asignatura>()
                .HasKey(a => new { a.IdAsignatura});
        }

        //todos los dbsets
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<ProfesorAsignatura> ProfesorAsignaturas { get; set; }
        public DbSet<EstudianteAsignatura> EstudianteAsignaturas { get; set; }
    }
}
