using System.ComponentModel.DataAnnotations;
namespace G_Project.Models

{
    public class Project
    {
        [Key]
        public int Id { get; set; }    
        public int Level { get; set; }
        public string Notes { get; set; }
        public virtual IEnumerable<DescentData>? Descent_Data { get; set; }
    }
}
