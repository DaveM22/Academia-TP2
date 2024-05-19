using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Business.Data.Mapping
{
    public class ComisionConfiguration : IEntityTypeConfiguration<Comision>
    {
        public void Configure(EntityTypeBuilder<Comision> builder)
        {
            builder.ToTable("comisiones");
            builder.Property(x => x.Id).HasColumnName("id_comision");
            builder.Property(x => x.Descripcion).HasColumnName("desc_comision");
            builder.Property(x => x.AnioEspecialidad).HasColumnName("anio_especialidad");
            builder.Property(x => x.PlanId).HasColumnName("id_plan");
            builder.HasOne(x => x.Plan).WithMany().HasForeignKey(x => x.PlanId);
            builder.HasMany(x => x.Cursos).WithOne(x => x.Comision).HasForeignKey(x => x.ComisionId);
        }
    }
}
