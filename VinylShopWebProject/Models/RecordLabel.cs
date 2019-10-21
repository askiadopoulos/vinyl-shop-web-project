using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    public class RecordLabel
    {
        // Properties

        // Primary Key: Stop using identity auto-increment
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Id { get; set; }

        // Name
        [Required(ErrorMessage = "Name is required")]
        [StringLength(maximumLength: 50, MinimumLength = 1, ErrorMessage = "{0} must be between {1} to {2} chars")]
        public string Name { get; set; }

    }
}