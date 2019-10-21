using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    public class ContentFile
    {
        // Properties

        // Primary Key
        public short Id { get; set; }

        // FileName
        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        // ContentType
        [Required]
        [StringLength(100)]
        public string ContentType { get; set; }

        public byte[] Content { get; set; }

        public FileType FileType { get; set; }

        // Navigation Property
        // One-To-Many Relationship by following Conventions (Code First)
        // A product may (or may not), have up to two content files,
        // one for image (product thumbnail) and one for audio (sample)
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}