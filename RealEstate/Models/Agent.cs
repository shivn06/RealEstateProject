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
        // The required funtion tells the user of the website that the field cannot be left empty
        [DisplayName("Last Name")]  
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required]
        [DisplayName("First Name")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        [RegularExpression("^(((\\+?64\\s*[-\\.\\ ]?[3-9]|\\(?0[3-9]\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{4})|((\\+?64\\s*[-\\.\\(\\ ]?2\\d{1,2}[-\\.\\)\\ ]?|\\(?02\\d{1}\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{3,5})|((\\+?64\\s*[-\\.\\ ]?[-\\.\\(\\ ]?800[-\\.\\)\\ ]?|[-\\.\\(\\ ]?0800[-\\.\\)\\ ]?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?(\\d{2}|\\d{5})))|^$$", ErrorMessage ="Please enter a valid Phone Number")]
        public string Phone { get; set; }

        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public required ICollection<Client>Clients { get; set; }
        public required ICollection<Listing> Listings { get; set; }
    }
}