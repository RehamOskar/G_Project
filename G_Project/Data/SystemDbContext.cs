using Microsoft.EntityFrameworkCore;
using G_Project.Models;

namespace G_Project.Data
{
    public class SystemDbContext : DbContext
    {
        public SystemDbContext(DbContextOptions<SystemDbContext> options) : base(options)
        {
        }
        public DbSet<Importer> importers { get; set; }
        // public DbSet<keyAttribute> keyAttributes { get; set; }
        public DbSet<DescentData> descentDatas { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductInProduction> productInProductions { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<SampleInspection> sampleInspections { get; set; }
        public DbSet<Shipment> shipments { get; set; }
        public DbSet<StartOfActivity> startOfActivities { get; set; }
        public DbSet<StartOfProduction> startOfProductions { get; set; }
        public DbSet<TypesOfProducts> TypesOfProducts { get; set; }
        public DbSet<VirtualExamination> VirtualExmination { get; set; }

    

    }
}
    

