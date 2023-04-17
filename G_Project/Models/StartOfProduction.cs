using System.ComponentModel.DataAnnotations;

namespace G_Project.Models
{
    public class StartOfProduction
    {
        [Key]
        public int IdStartP { get; set; } 
        public int IdInvestor { get; set; }
        public string Purpose { get; set; }
        public string Description { get; set; }
        public string TypeOfActivityPeriod { get; set; }
        public virtual IEnumerable<ProductInProduction> ProductInProductions { get; set; }  

    }
}
