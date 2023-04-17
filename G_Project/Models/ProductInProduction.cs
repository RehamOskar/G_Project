using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_Project.Models
{
    public class ProductInProduction
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("TypesOfProducts")]
        public int TypesOfProductsId { get; set; }
        [ForeignKey("StartOfProduction")]
        public int IdStartP { get; set; }
        
        public virtual TypesOfProducts TypesOfProducts { get; set; }
        public virtual StartOfProduction StartOfProduction { get; set; }
    }
}
