using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    public class Agent
    {
        /// <summary>
        /// Agent's unique identifier
        /// </summary>
        [Key]
        [Comment("Unique identifier of the Agent")]
        public int Id { get; set; }

        /// <summary>
        /// Agent's phone number
        /// </summary>
        [Required]
        [MaxLength(AgentPhoneMaxLength)]
        [Comment("Phone of the Agent")]
        public string PhoneNumber { get; set; } = string.Empty;
        
        /// <summary>
        /// User identifier of the Agent
        /// </summary>
        [Required]
        [Comment("User Id of the Agent")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Identity user of the Agent
        /// </summary>
        public IdentityUser User { get; set; } = null!;
    }
}

//· Id – a unique integer, Primary Key
//· PhoneNumber – a string with min length 7 and max length 15 (required)
//· UserId – a string (required)
//· User – an IdentityUser object