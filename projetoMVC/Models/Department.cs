using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetoMVC.Models{
    public class Department{
        [Display(Name = "Codigo")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
        public ICollection<Seller> sellers {get; set;}

        public Department(int id, string name){
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller){
            sellers.Add(seller);
        }

        public double TotalSales(DateTime initialDate, DateTime finalDate){
            double total = 0;
            foreach (Seller seller in sellers)
            {
                foreach (SalesRecord sale in seller.sales){
                    if(sale.Date >= initialDate && sale.Date <= finalDate){
                        total += sale.Amount;
                    }
                }
            }
            return total;
        }
    }
}