using System.ComponentModel.DataAnnotations;

namespace G_Project.Models
{
    public class Product
    {
        [Key]
        public int ProdectID { get; set; }

        public string CommodityType { get; set; }
        public string TradeName { get; set; }
        public string NameProducingCompany { get; set; }
        public string CountryOrigin { get; set; }
        public int BatchNumber { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string PackageType { get; set; }
        public float PrductWeight { get; set; }
        public float Size { get; set; }
        public float Measure { get; set; }
        public int Number { get; set; }
        public int ImpotedQuantityItem { get; set; }
        public string Matching { get; set; }
        public int NumberOfSampleUnitsDrawn { get; set; }
        public string ResultOfPrevioousExaminationReport { get; set; }
        public DateTime ValidityPeriods { get; set; }
        public DateTime StatementCard { get; set; }
        public int ExaminationNumber { get; set; }

    }
}
