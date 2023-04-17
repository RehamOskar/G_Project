using System.ComponentModel.DataAnnotations;

namespace G_Project.Models
{
    public class Importer
    {
        [Key]
        public int ImporterID { get; set; }
        public string ActualName { get; set; }
        public string NameDocuments { get; set; }
        public string PhoneNumber { get; set; }


    }
}
