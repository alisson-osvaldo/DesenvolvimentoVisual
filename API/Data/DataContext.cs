using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //Construtor ctor + TAB
        public DataContext(DbContextOptions<DataContext> options ) : base(options) { }

        //Lista de propriedades que vão virar tabelas no banco

        public DbSet<Produto> Produtos { get ; set; }

        //public DbSet<Produtos> Produtos { get ; set }
    }
}