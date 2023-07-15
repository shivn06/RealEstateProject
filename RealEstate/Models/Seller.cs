namespace RealEstate.Models
{
    public class Seller
    { 
        public required int SellerID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public required ICollection<Listing> Listings { get; set; }
    }
}