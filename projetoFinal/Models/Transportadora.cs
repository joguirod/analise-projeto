using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoFinal.Models
{
    public class Transportadora
    {
        [Display(Name = "Id transportadora")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}