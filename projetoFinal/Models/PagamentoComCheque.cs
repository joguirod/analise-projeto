using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoFinal.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        [Display(Name = "Banco")]
        public int Banco { get; set; }
        [Display(Name = "Nome do banco")]
        public string NomeDoBanco { get; set; }        
    }
}