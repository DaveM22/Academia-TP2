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
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios");
            builder.Property(x => x.Id).HasColumnName("id_usuario");
            builder.Property(x => x.NombreUsuario).HasColumnName("nombre_usuario");
            builder.Property(x => x.Clave).HasColumnName("clave");
            builder.Property(x => x.PersonaId).HasColumnName("id_persona");
            builder.Property(x => x.Nombre).HasColumnName("nombre");
            builder.Property(x => x.Apellido).HasColumnName("apellido");
            builder.Property(x => x.Email).HasColumnName("email");
            builder.HasOne(x => x.Persona).WithOne(x => x.Usuario).IsRequired(false);
        }
    }
}
