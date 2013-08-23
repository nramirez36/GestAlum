using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TEST.Models.Mapping
{
    public class CiudadeMap : EntityTypeConfiguration<Ciudade>
    {
        public CiudadeMap()
        {
            // Primary Key
            this.HasKey(t => t.codCiudad);

            // Properties
            this.Property(t => t.nombre)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ciudades");
            this.Property(t => t.codCiudad).HasColumnName("codCiudad");
            this.Property(t => t.nombre).HasColumnName("nombre");
            this.Property(t => t.descripcion).HasColumnName("descripcion");
            this.Property(t => t.codProvincia).HasColumnName("codProvincia");

            // Relationships
            this.HasRequired(t => t.Provincia)
                .WithMany(t => t.Ciudades)
                .HasForeignKey(d => d.codProvincia);

        }
    }
}
