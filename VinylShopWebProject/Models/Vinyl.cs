using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    public class Vinyl : Product
    {
        // Default Constructor
        // Initialize an unordered collection of unique formats
        public Vinyl()
        {
            Formats = new HashSet<Format>();
        }

        // Properties

        // Artist
        [Required(ErrorMessage = "Artist is required")]
        [StringLength(maximumLength: 50, MinimumLength = 1, ErrorMessage = "{0} must be between {1} to {2} chars")]
        public string Artist { get; set; }

        // Title
        [Required(ErrorMessage = "Title is required")]
        [StringLength(maximumLength: 80, MinimumLength = 1, ErrorMessage = "{0} must be between {1} to {2} chars")]
        public string Title { get; set; }

        // ReleaseDate
        [Display(Name = "Release Date")]
        [CheckReleaseDate]
        public DateTime? ReleaseDate { get; set; }

        // Navigation Properties
        // One-To-Many Relationship by following Conventions (Code First)

        // Many vinyls may belong to one single genre
        public byte? GenreId { get; set; }
        public Genre Genre { get; set; }

        // A record label may own more than one vinyls
        public short? RecordLabelId { get; set; }
        public RecordLabel RecordLabel { get; set; }

        // Navigation Property
        // One-To-Many Relationship using Fluent API
        // A vinyl can be available in more than one formats
        public virtual ICollection<Format> Formats { get; set; }
    }
}