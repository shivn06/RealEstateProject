namespace RealEstate.Models
{
    public class Client
    {
        public required int ClientID { get; set; }
        public required string LastName { get; set; }
        public required string FirstName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public required int PostalCode { get; set; }

        public required ICollection<Agent>Agents { get; set; }
    }
}
