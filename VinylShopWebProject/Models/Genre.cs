using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    public class Genre
    {
        // Properties

        // Primary Key: Stop using identity auto-increment
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte Id { get; set; }

        // Genre
        [Required(ErrorMessage = "Genre is required")]
        [StringLength(maximumLength: 30, MinimumLength = 1, ErrorMessage = "{0} must be between {1} to {2} chars")]
        public string Name { get; set; }

    }
}