using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebAppBloom.Models;

// interface -> contratos, é o ais alto nivel de abstração
// Na orientação a objetos é a ponta do iceberg
// Funciona como um contrato com as classes
// Obriga geralmente a implementação
// Vamos implementar um método da interface

namespace WebAppBloom.EntityConfigs;

public class CompetenciaEntityConfig : IEntityTypeConfiguration<Competencia>
{
    // Fluent API
    public void Configure(EntityTypeBuilder<Competencia> builder)
    {
        builder.ToTable("Competencia");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
                .HasColumnName("Id");
        
        /*Coluna bloom*/
        builder.Property(c => c.ColunaBloom)
                .HasColumnName("ColunaBloom")
                .HasColumnType("varcar(60)")
                .IsRequired();
        
        builder.Property(c=> c.LinhaBloom)
                .HasColumnName("LinhaBloom")
                .HasColumnType("varcar(60)")
                .IsRequired();
    }
}

/* LAMBDA
int soma (int x, int y)
{
    return x+y
}
==
VARIAVEL => OPERAÇÃO (C É O OBJETO)
soma => c.x + c.y
*/