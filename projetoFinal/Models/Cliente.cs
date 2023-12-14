using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoFinal.Models
{
    public class Cliente
    {
        [Display(Name = "Id Cliente")]
        public int Id { get; set; }
        [Display(Name = "Nome Cliente")]
        public string Nome { get; set; } 
    }
}