using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TEST.Models.Mapping
{
    public class TiposDocumentoMap : EntityTypeConfiguration<TiposDocumento>
    {
        public TiposDocumentoMap()
        {
            // Primary Key
            this.HasKey(t => t.tipoDocumentoID);

            // Properties
            this.Property(t => t.descripcion)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TiposDocumentos");
            this.Property(t => t.tipoDocumentoID).HasColumnName("tipoDocumentoID");
            this.Property(t => t.descripcion).HasColumnName("descripcion");
        }
    }
}
