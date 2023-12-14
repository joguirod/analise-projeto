using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoFinal.Models
{
    public class NotaDeVenda
    {
        [Display(Name = "Id nota de venda")]
        public int Id { get; set; }
        [Display(Name = "Id pagamento")]
        public int IdPagamento { get; set; }
        [Display(Name = "Id transportadora")]
        public int IdTransportadora { get; set; }
        [Display(Name = "Id Vendedor")]
        public int IdVendedor { get; set; }
        [Display(Name = "Id Cliente")]
        public int IdCliente { get; set; }
        [Display(Name = "Data")]
        public DateTime Data { get; set; }
        [Display(Name = "Tipo")]
        public bool Tipo { get; set; }
        public virtual ICollection<Item> Items {get; set;}
    }
}