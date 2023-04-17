using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace G_Project.Models
{
    public class DescentData
    {
        [Key]
        public int DescentId { get; set; }
        [ForeignKey("Project")]
        public int Id { get; set; }
        
       
        public DateTime DescentTime { get; set; }
        public string Day { get; set; }
        public DateTime DescentDate { get; set; }
        public virtual Project Project { get; set; }
    }
}
