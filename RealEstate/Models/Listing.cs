namespace RealEstate.Models
{
    public class Listing
    {
        public int ListingID { get; set; }
        public required string ListingAddress { get; set; }
        public int  SellerID{ get; set; }
        public int AgentID { get; set; }
        
        public required Agent Agent { get; set; }
        public required Seller Seller { get; set; }
}
}
