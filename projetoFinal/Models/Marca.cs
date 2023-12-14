using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoFinal.Models
{
    public class Marca
    {
        [Display(Name = "Id marca")]
        public int Id { get; set; }
        [Display(Name = "Nome marca")]
        public string Nome { get; set; }
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }
    }
}