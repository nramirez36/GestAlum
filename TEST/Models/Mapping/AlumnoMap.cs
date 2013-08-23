using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TEST.Models.Mapping
{
    public class AlumnoMap : EntityTypeConfiguration<Alumno>
    {
        public AlumnoMap()
        {
            // Primary Key
            this.HasKey(t => t.alumnoID);

            // Properties
            this.Property(t => t.nombres)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.apellidos)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.telefonoFijo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.telefonoCelular)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.nacionalidad)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Alumnos");
            this.Property(t => t.alumnoID).HasColumnName("alumnoID");
            this.Property(t => t.nombres).HasColumnName("nombres");
            this.Property(t => t.apellidos).HasColumnName("apellidos");
            this.Property(t => t.direccionID).HasColumnName("direccionID");
            this.Property(t => t.tipoDocumentoID).HasColumnName("tipoDocumentoID");
            this.Property(t => t.nroDocumento).HasColumnName("nroDocumento");
            this.Property(t => t.telefonoFijo).HasColumnName("telefonoFijo");
            this.Property(t => t.telefonoCelular).HasColumnName("telefonoCelular");
            this.Property(t => t.nacionalidad).HasColumnName("nacionalidad");
            this.Property(t => t.fechaNacimiento).HasColumnName("fechaNacimiento");
            this.Property(t => t.edad).HasColumnName("edad");

            // Relationships
            this.HasRequired(t => t.Domicilio)
                .WithMany(t => t.Alumnos)
                .HasForeignKey(d => d.direccionID);
            this.HasRequired(t => t.TiposDocumento)
                .WithMany(t => t.Alumnos)
                .HasForeignKey(d => d.tipoDocumentoID);

        }
    }
}
