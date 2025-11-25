using Microsoft.EntityFrameworkCore;

public class AgroSolutionContext : DbContext
{
    public DbSet<Maquina> Maquinas { get; set; }
    private string connection = "Server=localhost;Port=3306;Database=AgroTec;Uid=root;Pwd=0123;";
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