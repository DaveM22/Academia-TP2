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
    public class CursoConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("cursos");
            builder.Property(x => x.Id).HasColumnName("id_curso");
            builder.Property(x => x.MateriaId).HasColumnName("id_materia");
            builder.Property(x => x.ComisionId).HasColumnName("id_comision");
            builder.Property(x => x.AnioCalendario).HasColumnName("anio_calendario");
            builder.Property(x => x.Cupo).HasColumnName("cupo");
            builder.HasOne(x => x.Materia).WithMany().HasForeignKey(x => x.MateriaId);
            builder.HasOne(x => x.Comision).WithMany().HasForeignKey(x => x.ComisionId);
            builder.HasMany(x => x.DocenteCursos).WithOne(x => x.Curso).HasForeignKey(x => x.CursoId);
        }
    }
}
