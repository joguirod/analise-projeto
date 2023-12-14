using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoFinal.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        [Display(Name = "Numero do cartão")]
        public string NumeroDoCartao { get; set; }
        [Display(Name = "Bandeira do cartão")]
        public string Bandeira { get; set; }
    }
}