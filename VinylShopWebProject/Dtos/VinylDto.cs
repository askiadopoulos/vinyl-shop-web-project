using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VinylShopWebProject.Models;

namespace VinylShopWebProject.Dtos
{
    public class VinylDto
    {
        // Artist
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string Artist { get; set; }

        // Title
        [Required]
        [StringLength(maximumLength: 80, MinimumLength = 1)]
        public string Title { get; set; }

        // ReleaseDate
        //[Display(Name = "Release Date")]
        [CheckReleaseDate]
        public DateTime? ReleaseDate { get; set; }

        public byte GenreId { get; set; }

        public Genre Genre { get; set; }

        public short RecordLabelId { get; set; }

        public RecordLabel RecordLabel { get; set; }

    }
}