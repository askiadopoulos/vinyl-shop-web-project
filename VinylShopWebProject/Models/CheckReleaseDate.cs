using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    // Custom Validation Attribute -> CheckReleaseDate
    public class CheckReleaseDate : ValidationAttribute
    {
        // In 1931, RCA Victor launched the first commercially available vinyl long-playing record,
        // marketed as program-transcription discs.
        private const int InitialDate = 1931;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Get a vinyl from a value object (via cast)
            var vinyl = (Vinyl)validationContext.ObjectInstance;

            if (vinyl.ReleaseDate == null)
                return new ValidationResult("Release Date is Required");

            // Check the release date of a vinyl
            // Property Value => is only available if the nullable symbol (?)
            // is used in the corresponding property ReleaseDate of class Vinyl
            var date = vinyl.ReleaseDate.Value.Year;

            // Accepted release dates are from 1931 till nowdays
            return (date >= InitialDate && date <= DateTime.Today.Year)
                ? ValidationResult.Success
                : new ValidationResult("Release date must be from 1931 and after");
        }
    }
}