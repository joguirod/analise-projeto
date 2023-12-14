using System.ComponentModel.DataAnnotations;

namespace projetoMVC.Models{
    public class Seller{
        [Display(Name = "Codigo")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public virtual ICollection<SalesRecord> sales {get; set;}

        public Seller(int id, string name, string email){
            Id = id;
            Name = name;
            Email = email;
        }
    
        public void AddSale(SalesRecord saleRecord){
            sales.Add(saleRecord);
        }

        public void RemoveSale(SalesRecord saleRecord){
            sales.Remove(saleRecord);
        }

        public double TotalSales(DateTime initialDate, DateTime finalDate){
            double total = 0;
            foreach (SalesRecord sale in sales){
                if(sale.Date >= initialDate && sale.Date <= finalDate){
                    total += sale.Amount;
                }
            }
            return total;
        }
    }
}