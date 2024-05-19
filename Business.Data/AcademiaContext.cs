using Business.Data.Mapping;
using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public class AcademiaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ME5L0JN\SQLEXPRESS;Initial Catalog=Academia;User Id=net; Password=net;Integrated Security=True");
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UsuarioConfiguration).Assembly);
        }


        private static AcademiaContext instance;



        public AcademiaContext() { }

        private AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options)
        {
        }

        public static AcademiaContext GetInstance(DbContextOptions<AcademiaContext> options)
        {
            if (instance == null)
            {
                instance = new AcademiaContext(options);
            }
            return instance;
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Especialidad> Especialidades { get; set; }

        public DbSet<Plan> Planes { get; set; }

        public DbSet<Comision> Comisiones { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<DocenteCurso> DocenteCursos { get; set;}

        public DbSet<AlumnoInscripcion> AlumnoInscripciones { get; set; }

        public DbSet<Modulo> Modulos { get; set; }

        public DbSet<ModuloUsuario> ModuloUsuarios { get; set; }
    }
}
