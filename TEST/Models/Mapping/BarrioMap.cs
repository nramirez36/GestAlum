using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TEST.Models.Mapping
{
    public class BarrioMap : EntityTypeConfiguration<Barrio>
    {
        public BarrioMap()
        {
            // Primary Key
            this.HasKey(t => t.codBarrio);

            // Properties
            this.Property(t => t.nombre)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Barrios");
            this.Property(t => t.codBarrio).HasColumnName("codBarrio");
            this.Property(t => t.nombre).HasColumnName("nombre");
            this.Property(t => t.descripcion).HasColumnName("descripcion");
            this.Property(t => t.codCiudad).HasColumnName("codCiudad");

            // Relationships
            this.HasRequired(t => t.Ciudade)
                .WithMany(t => t.Barrios)
                .HasForeignKey(d => d.codCiudad);

        }
    }
}
