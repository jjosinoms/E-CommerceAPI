using ApiProdutos.Services.Models;
using AutoMapper;
using ApiProdutos.Data.Entities;
using Microsoft.AspNetCore.Routing.Constraints;

namespace ApiProdutos.Services.Mappings
{
    /// <summary>
    /// Mapear transferencias de dados de Models para Entities
    /// </summary>
    public class ModelToEntityMap : Profile
    {
        //método construtor
        public ModelToEntityMap()
        {
            CreateMap<CategoriasPostModel, Categoria>()
                .AfterMap((src, dest) =>
                {
                    dest.IdCategoria = Guid.NewGuid();
                });

            CreateMap<CategoriasPutModel, Categoria>();

            CreateMap<ProdutosPostModel, Produto>()
                .AfterMap((src, dest) =>
                {
                    dest.IdProduto = Guid.NewGuid();
                    dest.DataHoraCadastro = DateTime.Now;
                });

            CreateMap<ProdutosPutModel, Produto>();
        }
    }
}
