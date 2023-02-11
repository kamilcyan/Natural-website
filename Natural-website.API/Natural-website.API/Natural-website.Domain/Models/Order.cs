namespace Natural_website.API.Models
{
    public class Order
    {
        public Int32 Order_Id { get; set; }
        public Int32 Quantity { get; set; }
        public Int32 Total { get; set; }
        public DateTime Order_Date { get; set; }
        public String Comment { get; set; }
    }
}
