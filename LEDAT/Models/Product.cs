using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace QLTV.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}