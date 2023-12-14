namespace projetoFinal.Models
{
    public class Produto
    {
        public int IdMarca { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; } 
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public virtual ICollection<Produto> Produtos {get; set;}
    }
}