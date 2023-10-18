using RealEstate.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RealEstate.Models
{
    public class Agent
    {
        [ScaffoldColumn(false)]
        public int AgentID { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [DataType(DataType.Text)]
        public required string LastName { get; set; }

        [Required]
        [DisplayName("First Name")]
        [DataType(DataType.Text)]
        public required string FirstName { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }

        public required ICollection<Client>Clients { get; set; }
        public required ICollection<Listing> Listings { get; set; }
    }
}
