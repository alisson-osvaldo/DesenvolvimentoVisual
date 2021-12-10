using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        // Entity Framework - Code First
        // Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            // Categorias.AddRange(new Categoria[]
            //     {
            //         new Categoria { Id = 1, Nome = "Categoria 1" },
            //     }
            // );
            // Produtos.AddRange(new Produto[]
            //     {
            //         new Produto { Id = 1, Nome = "Produto 1", Preco = 1, Quantidade = 1, CategoriaId = 1 },
            //         new Produto { Id = 2, Nome = "Produto 2", Preco = 2, Quantidade = 2, CategoriaId = 1 },
            //         new Produto { Id = 3, Nome = "Produto 3", Preco = 3, Quantidade = 3, CategoriaId = 1 },
            //     }
            // );
            // SaveChanges();
        }

        //Lista de propriedades que vão virar tabelas no banco
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}