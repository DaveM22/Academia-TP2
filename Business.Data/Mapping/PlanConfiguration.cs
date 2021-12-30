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
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.ToTable("planes");
            builder.Property(x => x.Id).HasColumnName("id_plan");
            builder.Property(x => x.Descripcion).HasColumnName("desc_plan");
            builder.Property(x => x.EspecialidadId).HasColumnName("id_especialidad");
            builder.HasOne(x => x.Especialidad).WithMany().HasForeignKey(x => x.EspecialidadId);
        }
    }
}
