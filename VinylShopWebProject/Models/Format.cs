using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    public class Format
    {
        // Default Constructor
        // Initialize an unordered collection of unique vinyls
        public Format()
        {
            Vinyls = new HashSet<Vinyl>();
        }

        // Properties

        // Primary Key
        public byte Id { get; set; }

        // Description
        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 1)]
        public string Description { get; set; }

        // Abbreviation
        [Required]
        [StringLength(maximumLength: 15, MinimumLength = 1)]
        public string Abbreviation { get; set; }

        // Comments
        [StringLength(maximumLength: 255, MinimumLength = 1)]
        public string Comments { get; set; }

        // Navigation Property
        // One-To-Many Relationship using Fluent API
        // A format can be available on many vinyls
        public virtual ICollection<Vinyl> Vinyls { get; set; }
    }
}