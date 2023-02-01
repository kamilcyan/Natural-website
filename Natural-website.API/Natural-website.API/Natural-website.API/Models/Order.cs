using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Natural_website.API.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public Int32 Order_Id { get; set; }
        public Int32 Quantity { get; set; }
        public Int32 Total { get; set; }
        public DateTime Order_Date { get; set; }
        public String Comment { get; set; }
    }
}
