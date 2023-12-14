namespace projetoFinal.Models
{
    public class NotaDeVenda
    {
        public int IdPagamento { get; set; }
        public int IdTransportadora { get; set; }
        public int IdVendedor { get; set; }
        public int IdCliente { get; set; }
        public DateTime Data { get; set; }
        public bool Tipo { get; set; }
        public virtual ICollection<Item> Items {get; set;}
    }
}