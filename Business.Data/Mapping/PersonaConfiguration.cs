using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data.Mapping
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("personas");
            builder.Property(x => x.Id).HasColumnName("id_persona");
            builder.Property(x => x.Direccion).HasColumnName("direccion");
            builder.Property(x => x.FechaNacimiento).HasColumnName("fecha_nac");
            builder.Property(x => x.Legajo).HasColumnName("legajo");
            builder.Property(x => x.Nombre).HasColumnName("nombre");
            builder.Property(x => x.Apellido).HasColumnName("apellido");
            builder.Property(x => x.Telefono).HasColumnName("telefono");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.TipoPersona).HasColumnName("tipo_persona");
            builder.Property(x => x.PlanId).HasColumnName("id_plan");
            builder.HasMany(x => x.DocenteCurso).WithOne(x => x.Docente).HasForeignKey(x => x.DocenteId);
            builder.HasMany(x => x.Inscripciones).WithOne(x => x.Alumno).HasForeignKey(x => x.AlumnoId);
            builder.HasOne(x => x.Plan).WithOne();
        }
    }
}
