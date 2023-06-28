namespace RealEstate.Models
{
    public class Listing
    {
        public int ListingID { get; set; }
        public string ListingAddress { get; set; }
        public int  SellerID{ get; set; }
        public int AgentID { get; set; }
        
        public Agent Agent { get; set; }
        public Seller Seller { get; set; }
}
}
