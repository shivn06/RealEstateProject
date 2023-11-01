using RealEstate.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RealEstate.Models
{
    public class Agent
    {
        public int AgentID { get; set; }

        [Required]
        // The required funtion tells the user of the website that the field cannot be left empty
        [DisplayName("Last Name")]
        // The DisplayName annotation configures the label shown above a data input box
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "You have entered an Invalid Character")]
        // This Regular Expression only allows the user to input Letters, disallowing numbers and special characters
        public string LastName { get; set; }

        [Required]
        [DisplayName("First Name")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "You have entered an Invalid Character")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^(((\\+?64\\s*[-\\.\\ ]?[3-9]|\\(?0[3-9]\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{4})|((\\+?64\\s*[-\\.\\(\\ ]?2\\d{1,2}[-\\.\\)\\ ]?|\\(?02\\d{1}\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{3,5})|((\\+?64\\s*[-\\.\\ ]?[-\\.\\(\\ ]?800[-\\.\\)\\ ]?|[-\\.\\(\\ ]?0800[-\\.\\)\\ ]?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?(\\d{2}|\\d{5})))|^$$", ErrorMessage ="Please enter a valid Phone Number")]
        // The RegularExpression Annotation sets a specific format that data can be entered, in this instance it stops the user from entering invalid phone numbers
        public string Phone { get; set; }

        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public ICollection<Client>Clients { get; set; }

        public ICollection<Listing> Listings { get; set; }
        // The ICollection means that this table is a foreign key placed in another table, in this case it is placed in the listings table.
    }
}