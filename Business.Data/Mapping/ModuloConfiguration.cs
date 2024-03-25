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
    public class ModuloConfiguration : IEntityTypeConfiguration<Modulo>
    {
        public void Configure(EntityTypeBuilder<Modulo> builder)
        {
            builder.ToTable("modulos");
            builder.Property(x => x.Id).HasColumnName("id_modulo");
            builder.Property(x => x.Descripcion).HasColumnName("desc_modulo");
            builder.Property(x => x.Ejecuta).HasColumnName("ejecuta");
        }
    }
}
