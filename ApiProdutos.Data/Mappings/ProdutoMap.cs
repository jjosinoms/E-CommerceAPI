using ApiProdutos.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProdutos.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //nome da tabela no banco de dados
            builder.ToTable("PRODUTO");

            //definir a chave primária da tabela
            builder.HasKey(c => c.IdProduto);

            //mapeamento dos campos
            builder.Property(p => p.IdProduto)
                .HasColumnName("IDPRODUTO");

            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnName("DESCRICAO")
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasColumnName("PRECO")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.Quantidade)
                .HasColumnName("QUANTIDADE")
                .IsRequired();

            builder.Property(p => p.DataHoraCadastro)
                .HasColumnName("DATAHORACADASTRO")
                .IsRequired();

            builder.Property(p => p.IdCategoria)
                .HasColumnName("IDCATEGORIA")
                .IsRequired();

            //mapeamento do relacionamento 1 para muitos
            //e da foreign key (chave estrangeira)
            builder.HasOne(p => p.Categoria) //Produto TEM 1 Categoria
                .WithMany(c => c.Produtos) //Categoria TEM MUITOS Produtos
                .HasForeignKey(p => p.IdCategoria); // Chave Estrangeira

        }

    }
}
