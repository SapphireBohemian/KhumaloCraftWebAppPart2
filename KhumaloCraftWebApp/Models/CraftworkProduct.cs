using System;
using System.ComponentModel.DataAnnotations;

namespace KhumaloCraftWebApp.Models
{
    public class CraftworkProduct
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
