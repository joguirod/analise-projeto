using Microsoft.EntityFrameworkCore;

namespace projetoFinal.Models
{
    public class MyDbContext : DbContext
    {
    public MyDbContext(DbContextOptions<MyDbContext> options) :
    base(options)
    {
    }
    public DbSet<Cliente> Clinte {get; set;}
    public DbSet<Vendedor> Vendedor {get; set;}
    public DbSet<Transportadora> Transportadora {get; set;}
    public DbSet<Pagamento> Pagamento {get; set;}
    public DbSet<NotaDeVenda> NotaDeVenda {get; set;}
    public DbSet<TipoDePagamento> TipoDePagamento {get; set;}
    public DbSet<PagamentoComCartao> PagamentoComCartao {get; set;}
    public DbSet<PagamentoComCheque> PagamentoComCheque {get; set;}
    public DbSet<Marca> Marca {get; set;}
    public DbSet<Produto> Produto {get; set;}
    public DbSet<Item> Item {get; set;}
    }
}