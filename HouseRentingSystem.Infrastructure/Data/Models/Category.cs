using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    public class Category
    {
        /// <summary>
        /// Unique identifier of the Category
        /// </summary>
        [Key]
        [Comment("Category unique identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the Category
        /// </summary>
        [Required]
        [MaxLength(Constants.DataConstants.CategoryMaxLength)]
        [Comment("Category's name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Collection of House entities of a Category
        /// </summary>
        public List<House> Houses { get; set; } = new List<House>();
    }
}