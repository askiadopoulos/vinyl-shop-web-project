using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    public class Category
    {
        // Properties

        // Primary Key: Stop using identity auto-increment
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte Id { get; set; }

        // Description
        [Required(ErrorMessage = "Description is required")]
        [StringLength(maximumLength: 50, MinimumLength = 1, ErrorMessage = "{0} must be between {1} to {2} chars")]
        public string Description { get; set; }

        // Navigation Properties

        // One-To-Many Relationship by following Convention (Code First)
        // As a single, a category may be declared in more than one products
        public ICollection<Product> Products { get; set; }


    }
}