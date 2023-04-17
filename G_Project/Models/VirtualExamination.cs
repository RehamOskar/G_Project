using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_Project.Models
{
    public class VirtualExamination
    {
        [Key]
        public int VirtualExaminationId { get; set;}
        [ForeignKey("Product")]
        public int ProdectID { get; set; }
        public virtual Product Product { get; set; }
        public string ExaminationName { get; set; }

    }
}
