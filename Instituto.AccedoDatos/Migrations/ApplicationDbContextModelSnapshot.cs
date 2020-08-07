﻿// <auto-generated />
using System;
using Instituto.AccedoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Instituto.AccedoDatos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Institucion.Negocio.Asignatura", b =>
                {
                    b.Property<int>("IdAsignatura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAsignatura");

                    b.ToTable("Asignaturas");
                });

            modelBuilder.Entity("Institucion.Negocio.Estudiante", b =>
                {
                    b.Property<int>("IdEstudiante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEstudiante");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("Institucion.Negocio.EstudianteAsignatura", b =>
                {
                    b.Property<int>("IdAsignatura")
                        .HasColumnType("int");

                    b.Property<int>("IdEstudiante")
                        .HasColumnType("int");

                    b.HasKey("IdAsignatura", "IdEstudiante");

                    b.HasIndex("IdEstudiante");

                    b.ToTable("EstudianteporAsignatura");
                });

            modelBuilder.Entity("Instituto.Entidad.Curso", b =>
                {
                    b.Property<int>("IdCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CursoIdCurso")
                        .HasColumnType("int");

                    b.Property<int?>("EstudianteIdEstudiante")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCurso");

                    b.HasIndex("CursoIdCurso");

                    b.HasIndex("EstudianteIdEstudiante");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Instituto.Entidad.Profesor", b =>
                {
                    b.Property<int>("IdProfesor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProfesor");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("Instituto.Entidad.ProfesorAsignatura", b =>
                {
                    b.Property<int>("IdAsignatura")
                        .HasColumnType("int");

                    b.Property<int>("IdProfesor")
                        .HasColumnType("int");

                    b.Property<int?>("EstudianteIdEstudiante")
                        .HasColumnType("int");

                    b.HasKey("IdAsignatura", "IdProfesor");

                    b.HasIndex("EstudianteIdEstudiante");

                    b.HasIndex("IdProfesor");

                    b.ToTable("ProfesorporAsignatura");
                });

            modelBuilder.Entity("Institucion.Negocio.EstudianteAsignatura", b =>
                {
                    b.HasOne("Institucion.Negocio.Asignatura", "Asignatura")
                        .WithMany("EstudianteAsignaturas")
                        .HasForeignKey("IdAsignatura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Institucion.Negocio.Estudiante", "Estudiante")
                        .WithMany("EstudianteAsignaturas")
                        .HasForeignKey("IdEstudiante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Instituto.Entidad.Curso", b =>
                {
                    b.HasOne("Instituto.Entidad.Curso", null)
                        .WithMany("Cursos")
                        .HasForeignKey("CursoIdCurso");

                    b.HasOne("Institucion.Negocio.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteIdEstudiante");
                });

            modelBuilder.Entity("Instituto.Entidad.ProfesorAsignatura", b =>
                {
                    b.HasOne("Institucion.Negocio.Estudiante", null)
                        .WithMany("ProfesorAsignaturas")
                        .HasForeignKey("EstudianteIdEstudiante");

                    b.HasOne("Institucion.Negocio.Asignatura", "Asignatura")
                        .WithMany()
                        .HasForeignKey("IdAsignatura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Instituto.Entidad.Profesor", "Profesor")
                        .WithMany("ProfesorAsignaturas")
                        .HasForeignKey("IdProfesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
