using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Core.Constants.ErrorMessages;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Core.Models.Agent
{
    public class BecomeAgentFormModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(AgentPhoneMaxLength,
            MinimumLength = AgentPhoneMinLength,
            ErrorMessage = InvalidLengthErrorMessage)]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
