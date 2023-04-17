
using System.ComponentModel.DataAnnotations;

namespace G_Project.Models
{
    internal class keyAttribute : Attribute
    {
        [Key]
        public int keyAttributeID { get; set; }

    }
}