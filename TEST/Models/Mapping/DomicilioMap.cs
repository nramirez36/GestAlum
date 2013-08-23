using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TEST.Models.Mapping
{
    public class DomicilioMap : EntityTypeConfiguration<Domicilio>
    {
        public DomicilioMap()
        {
            // Primary Key
            this.HasKey(t => t.direccionID);

            // Properties
            this.Property(t => t.calle)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.altura)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.depto)
                .HasMaxLength(50);

            this.Property(t => t.piso)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Domicilios");
            this.Property(t => t.direccionID).HasColumnName("direccionID");
            this.Property(t => t.calle).HasColumnName("calle");
            this.Property(t => t.altura).HasColumnName("altura");
            this.Property(t => t.depto).HasColumnName("depto");
            this.Property(t => t.piso).HasColumnName("piso");
            this.Property(t => t.barrioID).HasColumnName("barrioID");
            this.Property(t => t.ciudadID).HasColumnName("ciudadID");
            this.Property(t => t.provinciaID).HasColumnName("provinciaID");

            // Relationships
            this.HasRequired(t => t.Barrio)
                .WithMany(t => t.Domicilios)
                .HasForeignKey(d => d.barrioID);
            this.HasRequired(t => t.Ciudade)
                .WithMany(t => t.Domicilios)
                .HasForeignKey(d => d.ciudadID);
            this.HasRequired(t => t.Provincia)
                .WithMany(t => t.Domicilios)
                .HasForeignKey(d => d.provinciaID);

        }
    }
}
