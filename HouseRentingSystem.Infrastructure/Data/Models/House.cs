using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    public class House
    {
        /// <summary>
        /// Unique identifier of the House entity class
        /// </summary>
        [Key]
        [Comment("House unique identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Title of the House
        /// </summary>
        [Required]
        [MaxLength(HouseTitleMaxLength)]
        [Comment("House Title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Address of the House
        /// </summary>
        [Required]
        [MaxLength(HouseAddressMaxLength)]
        [Comment("House Address")]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Description of the House
        /// </summary>
        [Required]
        [MaxLength(HouseDescMaxLength)]
        [Comment("House Description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Url that links to the House's image
        /// </summary>
        [Required]
        [Comment("Url of the House's image")]
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Price per month of the House
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Comment("House price per month")]
        public decimal PricePerMonth { get; set; }

        /// <summary>
        /// Id of the House's Category
        /// </summary>
        [Required]
        [Comment("Id of the House's Category")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Navigation property to the House's Category
        /// </summary>
        public Category Category { get; set; } = null!;

        /// <summary>
        /// Id of the House's Agent
        /// </summary>
        [Required]
        [Comment("Id of the House's Agent")]
        public int AgentId { get; set; }
        /// <summary>
        /// Navigation property to the House's Agent
        /// </summary>
        public Agent Agent { get; set; } = null!;

        /// <summary>
        /// Id of the House's renter
        /// </summary>
        [Comment("Id of the House's renter")]
        public string? RenterId { get; set; }
    }
}