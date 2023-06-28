namespace RealEstate.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }

        public ICollection<Agent>Agents { get; set; }
    }
}
