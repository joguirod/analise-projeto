using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoFinal.Models
{
    public class TipoDePagamento
    {
        [Display(Name = "Id forma de pagamento")]
        public int Id { get; set; }
        [Display(Name = "Id tipo de pagamento")]
        public int IdTipoDePagamento { get; set; }
        [Display(Name = "Nome do cobrado")]
        public string NomeDoCobrado { get; set; }
        [Display(Name = "Informacoes adicionais")]
        public string InformacoesAdicionais { get; set; }
    }
}