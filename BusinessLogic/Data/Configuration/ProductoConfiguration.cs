using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessLogic.Data.Configuration
{
    /* para podes hacer los constrains (reglas) */
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            //logitud de las propiedades de la clase producto
            builder.Property(p => p.Nombre).IsRequired().HasMaxLength(250);
            builder.Property(p => p.Descripcion).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Imagen).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.Precio).HasColumnType("decimal(18,2)");
            //relacion entre tablas de uno a muchos
            builder.HasOne(m => m.Marca).WithMany().HasForeignKey(p => p.MarcaId); //realizamos la clave foreane que tendra el producto
            builder.HasOne(c => c.Categoria).WithMany().HasForeignKey(p => p.CategoriaId); //realizamos la clave foreane que tendra el producto

        }
    }
}
