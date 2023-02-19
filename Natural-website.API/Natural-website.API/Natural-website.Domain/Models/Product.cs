namespace Natural_website.API.Models
{
    public class Product
    {
        public Int32 Product_Id { get; set; }
        public String? Name { get; set; }
        public decimal Price { get; set; }
        public Int32 Avaibility { get; set; }
        public String? Description { get; set; }
        public DateTime Provide_Date { get; set; }
        public decimal Product_Discount { get; set; }
        public String? Comment { get; set; }
        public String? Section { get; set; }
        public String? Picture { get; set; }
        public String? Provider { get; set; }
    }
}
