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
    public class MateriaConfiguration : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.ToTable("materias");
            builder.Property(x => x.Id).HasColumnName("id_materia");
            builder.Property(x => x.Descripcion).HasColumnName("desc_materia");
            builder.Property(x => x.HSSemanales).HasColumnName("hs_semanales");
            builder.Property(x => x.HSTotales).HasColumnName("hs_totales");
            builder.Property(x => x.PlanId).HasColumnName("id_plan");
            builder.HasOne(x => x.Plan).WithMany(x => x.Materias).HasForeignKey(x => x.PlanId);
        }
    }
}
