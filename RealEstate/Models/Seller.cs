namespace RealEstate.Models
{
    public class Seller
    { 
        public int SellerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<Listing> Listings { get; set; }
    }
}