using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoFinal.Models
{
    public class Pagamento
    {
        [Display(Name = "Id pagamento")]
        public int Id { get; set; }
        [Display(Name = "Data limite")]
        public DateTime dataLimite { get; set; }
        [Display(Name = "Valor")]
        public double Valor { get; set; }
        public bool Pago { get; set; }
    }
}