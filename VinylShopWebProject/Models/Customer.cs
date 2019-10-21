using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    public class Customer
    {
        // Properties

        // Primary Key
        public int Id { get; set; }

        // FirstName
        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "{0} must be between {1} to {2} chars")]
        public string FirstName { get; set; }

        // LastName
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "{0} must be between {1} to {2} chars")]
        public string LastName { get; set; }

        // DateOfBirth
        public DateTime DateOfBirth { get; set; }

        // Calculated Property: FullName
        public string FullName
        {
            get
            {
                return LastName + " " + FirstName;
            }
        }

        // Navigation Property
        // One-To-One Relationship by following Conventions (Code First)
        // As a single, a customer is linked with one AspNetUsers account
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }


    }
}