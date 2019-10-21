using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    public class Product
    {
        // Properties
        public int Id { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public short Quantity { get; set; }

        [Required]
        [Display(Name = "Available for Sale?")]
        public bool IsAvailable { get; set; }

        // Navigation Properties

        // One-To-Many Relationship by following Convention (Code First)
        // A product belongs only in one single category
        public byte? CategoryId { get; set; }
        public Category Category { get; set; }

    }
}