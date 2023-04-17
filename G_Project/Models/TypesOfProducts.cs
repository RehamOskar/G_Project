using System.ComponentModel.DataAnnotations;

namespace G_Project.Models
{
    public class TypesOfProducts
    {
        [Key]
        public int TypesOfProductsId { get; set; }
        public string TypeOfProduct { get; set; }
        public string TradeMark { get; set; }
        public string ProductionCapacity { get; set; }
        //الطاقة الانتاجية
        public string ProductRegistration { get; set; }

        public virtual IEnumerable<TypesOfProducts> TypesOfProduct { get; set; }
    }
}
