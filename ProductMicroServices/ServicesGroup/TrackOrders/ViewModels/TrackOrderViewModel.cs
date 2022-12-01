namespace TrackOrders.ViewModels
{
    public class TrackOrderViewModel
    {
        public long Track_Order_ID { get; set; }
        public string? Customer_Order_ID { get; set; }
        public long Customer_ID { get; set; }
        public long Order_ID { get; set; }
        public DateTime Added_On { get; set; }
        public string Added_By { get; set; }
    }
}