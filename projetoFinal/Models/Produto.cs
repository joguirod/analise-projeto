using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoFinal.Models
{
    public class Produto
    {
        [Display(Name = "Id do produto")]
        public int Id { get; set; }
        [Display(Name = "Id da marca")]
        public int IdMarca { get; set; }
        [Display(Name = "Nome do produto")]
        public string Nome { get; set; }
        [Display(Name = "Descricao")]
        public string Descricao { get; set; } 
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        [Display(Name = "Preco")]
        public double Preco { get; set; }
    }
}