using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    internal static class ConstantAttribute
    {
        // Regex Paterns

        // Must only use letters.
        // The first letter is required to be uppercase.
        // White space, numbers, and special characters are not allowed.
        public const string OnlyLettersFirstUpperNoSpaceNumbersSpecialChars = @"^[A-Z]+[a-zA-Z""'\s-]*$";

        // Must only use numbers.
        // Scale of 2 digits.
        // Allows up to two digits after the decimal point.
        public const string ScaleOfTwoDigits = @"^\d+.?\d{0,2}$";

        //[ReadOnly(true)]: makes a property only readable

        // Stop auto-increment and use user-defined Primary Key
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
    }
}