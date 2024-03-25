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
    public class ModuloUsuarioConfiguration : IEntityTypeConfiguration<ModuloUsuario>
    {
        public void Configure(EntityTypeBuilder<ModuloUsuario> builder)
        {
            builder.ToTable("modulos_usuarios");
            builder.Property(x => x.Id).HasColumnName("id_modulo_usuario");
            builder.Property(x => x.ModuloId).HasColumnName("id_modulo");
            builder.Property(x => x.UsuarioId).HasColumnName("id_usuario");
            builder.Property(x => x.Alta).HasColumnName("alta");
            builder.Property(x => x.Baja).HasColumnName("baja");
            builder.Property(x => x.Modificacion).HasColumnName("modificacion");
            builder.Property(x => x.Consulta).HasColumnName("consulta");
            builder.HasOne(x => x.Usuario).WithMany(x => x.Modulos);
            builder.HasOne(x => x.Modulo);
        }
    }
}
