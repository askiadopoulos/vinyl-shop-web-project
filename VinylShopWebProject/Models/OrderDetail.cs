using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    // Associative Entity (Junction Table)
    public class OrderDetail
    {
        // Composite Primary Key

        // Foreign Key: References the entity model Order
        [Key, Column(Order = 0)]
        public int OrderId { get; set; }
        // Foreign Key: References the entity model Product
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }

        // Navigation Properties
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

        // Additional Properties / Fields
        public short Quantity { get; set; }
        public decimal FinalPrice { get; set; }
        public DateTime DateTimePaid { get; set; }

    }
}