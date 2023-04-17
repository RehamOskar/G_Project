using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_Project.Models
{
    public class StartOfActivity 
    {
        [Key]
        public int IdStartA { get; set; }
        public string Result { get; set; }
        public string Description { get; set; } 
        public string Purpose { get; set; }

    }
}