namespace Natural_website.API.Models
{
    public class Customer
    {
        public Int32 Customer_Id { get; set; }
        public String First_Name { get; set; }
        public String Last_Name { get; set; }
        public String AddressLine1 { get; set; }
        public String AddressLine2 { get; set; }
        public String AddressLine3 { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Status { get; set; }
        public Int32 Customer_Discount { get; set; }
        public String Comment { get; set; }
    }
}
