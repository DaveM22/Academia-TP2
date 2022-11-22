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
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-22FB5O9F\SQLEXPRESS;Initial Catalog=Academia;User Id=net; Password=net;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UsuarioConfiguration).Assembly);
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Especialidad> Especialidades { get; set; }

        public DbSet<Plan> Planes { get; set; }

        public DbSet<Comision> Comisiones { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<DocenteCurso> DocenteCursos { get; set;}
    }
}
