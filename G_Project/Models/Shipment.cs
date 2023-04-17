using System.ComponentModel.DataAnnotations;

namespace G_Project.Models
{
    public class Shipment
    {
        [Key]
        public int ShipmentID { get; set; }
        public int ShipmentNumberMade { get; set; }
        public DateTime ShipmentArrivalDate { get; set; }
        public string Location_Of_ItemsMade { get; set; }
        public int Number_Of_ItemsMade { get; set; }
        public int Number_Of_Items_For_Examination { get; set; }
        public int TotalQuantityMade { get; set; }
        public int TotalQuantityItemsMade { get; set; }
        public int TotalOfShipment { get; set; }
        public  string ShipmentData { get; set; }
        public DateTime DateReceiptShipment { get; set; }
        //public DateTime DateTransportation { get; set; }
        public int Number_Of_Transportation { get; set; }

       public int TransportationID { get; set; }
        public string TransportationType { get; set; }

        public int ReportNumber { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime Date_Of_CustomDeclaration { get; set; }
        public int Number_Of__CustomDeclaration { get; set; }
    }
}
