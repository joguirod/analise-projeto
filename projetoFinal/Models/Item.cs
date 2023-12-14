using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoFinal.Models
{
    public class Item
    {
        [Display(Name = "Id Item")]
        public int Id { get; set; }
        [Display(Name = "Id Produto")]
        public int IdProduto { get; set; }
        [Display(Name = "Percentual")]
        public int Percentual { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        public virtual ICollection<Produto> Produtos {get; set;}
    }
}