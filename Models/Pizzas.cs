using System.ComponentModel.DataAnnotations;

namespace Pizza.API.Models
{
    public class Pizzas
    {
    
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Name of Pizza
        /// </summary>
        [MaxLength(100)]
        public string? Name { get; set; }
        
        /// <summary>
        /// Checks if Pizza contains Gluten
        /// returns a boolean value
        /// </summary>
        [Required]
        
        public bool IsGlutenFree { get; set; }
    }
}
