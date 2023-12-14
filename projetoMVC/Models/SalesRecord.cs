using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoMVC.Models{
    public class SalesRecord{
        [Display(Name = "Codigo")]
        public int Id { get; set; }
        [Display(Name = "Amount")]
        public double Amount { get; set; }
        [Display(Name = "Status")]
        public SaleStatus Status {get; set;}
        public DateTime Date { get; set; }

        public SalesRecord(int id, double amount, SaleStatus status)
        {   
            Id = id;
            Amount = amount;
            Status = status;
        }
    
    }
}