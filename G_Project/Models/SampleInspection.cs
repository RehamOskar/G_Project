using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_Project.Models
{
    public class SampleInspection
    {
        [Key]
        public int SampleId { get; set; }
        public string Purpose { get; set; }
        public int Result { get; set; }
        public string Matching { get; set; }
        public string CustomsDeclaration { get; set; }

        [ForeignKey("ShipmentID")]
        public int ShipmentId { get; set; }
        public virtual Shipment Shipment { get; set; }

        [ForeignKey("ImporterID")]
        public int ImporterId { get; set; }
        public virtual Importer Importer { get; set; }

        [ForeignKey("ProdectID")]
        public int ProdectID { get; set; }
        public virtual Project Project { get; set; }
        
        public int Document { get; set; }
        public string TradeName { get; set; }
        public int EditingReportNumber { get; set; }
        public DateTime EditingDate { get; set; }
        public string NotchedSide { get; set; }
        public string Purpose_Of_Scoring { get; set; }
        public string DetectiveInspectore   { get; set; }


    }
}
