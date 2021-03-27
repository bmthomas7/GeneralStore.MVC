using System;
using System.ComponentModel.DataAnnotations;

namespace GeneralStore.MVC.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public String Name { get; set; }
        [Required]
        [Display(Name = "# In Stock")]
        public int InventoryCount { get; set; }
        [Required]
        public Decimal Price { get; set; }
        [Required]
        [Display(Name = "It is food")]
        public Boolean IsFood { get; set; }
    }
}