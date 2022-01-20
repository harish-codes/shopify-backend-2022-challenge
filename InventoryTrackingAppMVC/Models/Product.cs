﻿using System.ComponentModel.DataAnnotations;

namespace InventoryTrackingAppMVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
