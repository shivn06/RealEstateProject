namespace RealEstate.Models
{
    public class Agent
    {
        public int AgentID { get; set; }
        public required string LastName { get; set; }
        public required string FirstName { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }

        public required ICollection<Client>Clients { get; set; }
        public required ICollection<Listing> Listings { get; set; }
    }
}
