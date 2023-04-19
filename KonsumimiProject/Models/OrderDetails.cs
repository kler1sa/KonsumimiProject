using KonsumimiProject.Models;
using System.Net.Http.Headers;

namespace KonsumimiProject.Models
{
    public class OrderDetails
    { 
        public int Id { get; set; }
        public int quantity { get; set; }
        public decimal unitprice { get; set; }
        public decimal discount { get; set; }
        public int OrderId { get; set; }
        public virtual Orders? Orders { get; set; }
        public int Productid { get; set; }
        public virtual Product? Product { get; set; }

    }
}
