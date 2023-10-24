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
    public class AlumnoInscripcionConfiguration : IEntityTypeConfiguration<AlumnoInscripcion>
    {
        public void Configure(EntityTypeBuilder<AlumnoInscripcion> builder)
        {
            builder.ToTable("alumnos_inscripciones");
            builder.Property(x => x.Id).HasColumnName("id_inscripcion");
            builder.Property(x => x.AlumnoId).HasColumnName("id_alumno");
            builder.Property(x => x.CursoId).HasColumnName("id_curso");
            builder.Property(x => x.Nota).HasColumnName("nota");
            builder.Property(x => x.Condicion).HasColumnName("condicion");
            builder.HasOne(x => x.Alumno).WithMany().HasForeignKey(x => x.AlumnoId);
            builder.HasOne(x => x.Curso).WithMany().HasForeignKey(x => x.CursoId);
        }
    }
}
