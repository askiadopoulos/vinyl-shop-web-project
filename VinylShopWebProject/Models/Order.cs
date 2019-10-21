using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinylShopWebProject.Models
{
    public class Order
    {
        // Properties

        // Primary Key
        public int Id { get; set; }

        public DateTime OrderDateTime { get; set; }

        public bool IsPaid { get; set; }

        // Comments
        [StringLength(255)]
        public string Comments { get; set; }

        // Navigation Properties

        // One-To-Many Relationship using Fluent API
        // An order belongs to a single customer only
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Many-To-Many Relationship by following Conventions (Code First)
        // An single order may have more than one products
        //public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}