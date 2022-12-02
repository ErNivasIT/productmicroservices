using System.ComponentModel.DataAnnotations;
namespace TrackOrders.Models
{
    public class TrackOrder
    {
        [Key]
        public long Track_Order_ID { get; set; }
        public string? Customer_Order_ID { get; set; }
        public long Customer_ID { get; set; }
        public string Customer_Name { get; set; }
        public long Order_ID { get; set; }
        public DateTime Order_Date { get; set; }
        public DateTime Added_On { get; set; }
        public string Added_By { get; set; }
        public decimal Order_Amount { get; set; }
    }
}