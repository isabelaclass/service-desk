using Microsoft.EntityFrameworkCore;
namespace ServiceDesk.Data;
public class ServiceDeskDbContext : DbContext
{
    public DbSet<Dispositivo>? Dispositivo { get; set; }
    public DbSet<Usuario>? Usuario { get; set; }
    public DbSet<CentroDeCusto> CentroDeCusto {  get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=servicedesk.db;Cache=Shared");
    }
}
