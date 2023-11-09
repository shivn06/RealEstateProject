using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RealEstate.Models
{
    public class Client
    {
        public int ClientID { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage ="You have entered an Invalid Character")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("First Name")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "You have entered an Invalid Character")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        [RegularExpression("^(((\\+?64\\s*[-\\.\\ ]?[3-9]|\\(?0[3-9]\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{4})|((\\+?64\\s*[-\\.\\(\\ ]?2\\d{1,2}[-\\.\\)\\ ]?|\\(?02\\d{1}\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{3,5})|((\\+?64\\s*[-\\.\\ ]?[-\\.\\(\\ ]?800[-\\.\\)\\ ]?|[-\\.\\(\\ ]?0800[-\\.\\)\\ ]?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?(\\d{2}|\\d{5})))|^$$", ErrorMessage = "Please enter a valid Phone Number e.g. 021 123456789, or +64 211234567")]
        public string Phone { get; set; }

        [Required]
        [DisplayName("Address")]
        [RegularExpression("^[A-Za-z0-9, ]+$", ErrorMessage = "You have entered an Invalid Character")]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        [RegularExpression("^\\d{4}$", ErrorMessage = "Invalid Postal Code")]
        // This Regular Expression only allows the user to enter numbers, disallowing letters and special characters
        public int PostalCode { get; set; }

        public ICollection<Agent>Agents { get; set; }
        
    }
}
