using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TEST.Models.Mapping;

namespace TEST.Models
{
    public partial class SISGAContext : DbContext
    {
        static SISGAContext()
        {
            Database.SetInitializer<SISGAContext>(null);
        }

        public SISGAContext()
            : base("Name=SISGAContext")
        {
        }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Barrio> Barrios { get; set; }
        public DbSet<Ciudade> Ciudades { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TiposDocumento> TiposDocumentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlumnoMap());
            modelBuilder.Configurations.Add(new BarrioMap());
            modelBuilder.Configurations.Add(new CiudadeMap());
            modelBuilder.Configurations.Add(new DomicilioMap());
            modelBuilder.Configurations.Add(new ProvinciaMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TiposDocumentoMap());
        }
    }
}
