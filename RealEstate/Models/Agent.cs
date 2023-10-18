﻿using RealEstate.Models;
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
        [Phone]
        [RegularExpression("^[1-9]\\d{2}-\\d{3}-\\d{4}",ErrorMessage ="Please enter a valid Phone Number")]
        public string Phone { get; set; }

        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }

        public required ICollection<Client>Clients { get; set; }
        public required ICollection<Listing> Listings { get; set; }
    }
}