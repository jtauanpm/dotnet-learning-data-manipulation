using DevIO.IntroducaoEfCore.App.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.IntroducaoEfCore.App.Data.Configurations;

public class PedidoItemConfiguration : IEntityTypeConfiguration<PedidoItem>
{
    public void Configure(EntityTypeBuilder<PedidoItem> builder)
    {
        builder.ToTable("PedidoItems");
        builder.HasKey(i => i.Id);
        builder.Property(i => i.Quantidade).HasDefaultValue(1).IsRequired();
        builder.Property(i => i.Valor).IsRequired();
        builder.Property(i => i.Desconto).IsRequired();
    }
}