using Microsoft.EntityFrameworkCore;
using WebAppBloom.Models;
using WebAppBloom.EntityConfigs;


namespace WebAppBloom.Contexts;
//dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// DbContext --> Banco
// DbSet --> Tabela
// Banco ":" Herança

public class AppDbConext : DbContext{
    //Tabela - Criar a tabela
    //DbSet<Competencia>
    public DbSet<Competencia> Competencias => Set<Competencia>(); // tabela
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAB-F08-24; Database=WebAppBloom;User Id=sa;Password=senai@123; TrustServerCertificate=True;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CompetenciaEntityConfig());
    }
}

