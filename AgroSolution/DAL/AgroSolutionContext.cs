using Microsoft.EntityFrameworkCore;

public class AgroSolutionContext : DbContext
{
    public DbSet<Maquina> Maquinas { get; set; }
    private string connection = "Server=db33744.databaseasp.net; Database=db33744; Uid=db33744; Pwd=4An?h-B2!C7q;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Maquina>().ToTable("Maquinas");
        builder.Entity<Maquina>().HasData(
            new Maquina()
            {
                Id = 1,
                Nome = "Trator de Tração Simples",
                DataCadastro = DateTime.Now,
                Status = true
            }
        );
    }
}