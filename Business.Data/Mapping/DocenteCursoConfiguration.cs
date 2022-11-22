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
    public class DocenteCursoConfiguration : IEntityTypeConfiguration<DocenteCurso>
    {
        public void Configure(EntityTypeBuilder<DocenteCurso> builder)
        {
            builder.ToTable("docentes_cursos");
            builder.Property(x => x.Id).HasColumnName("id_dictado");
            builder.Property(x => x.CursoId).HasColumnName("id_curso");
            builder.Property(x => x.DocenteId).HasColumnName("id_docente");
            builder.Property(x => x.DocenteCargo).HasColumnName("cargo");
        }
    }
}
