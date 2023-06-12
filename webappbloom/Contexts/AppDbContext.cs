namespace WebAppBloom.Contexts;
using Microsoft.EntityFrameworkCore;
using WebAppBloom.Models;
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
        optionsBuilder.UseSqlServer("Sever=LAB-F08-24; Database=WebAppBloom;User Id=sa;Password=senai@123; TrustServerCertificate=True;");
    }
}