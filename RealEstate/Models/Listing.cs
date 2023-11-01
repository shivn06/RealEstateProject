using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RealEstate.Models
{
    public class Listing
    {
        public int ListingID { get; set; }

        [Required]
        [DisplayName("Listing Address")]
        [RegularExpression("^[A-Za-z0-9, ]+$", ErrorMessage = "You have entered an Invalid Character")]
        public string ListingAddress { get; set; }

        [Required]
        public int  SellerID{ get; set; }

        [Required]
        public int AgentID { get; set; }
        
        public Agent Agent { get; set; }
        public Seller Seller { get; set; }
}
}
