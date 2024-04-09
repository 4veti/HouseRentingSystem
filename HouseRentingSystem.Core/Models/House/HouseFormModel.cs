using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;
using static HouseRentingSystem.Infrastructure.Constants.ErrorMessages;

namespace HouseRentingSystem.Core.Models.House
{
    public class HouseFormModel
    {
        [Required]
        [StringLength(HouseTitleMaxLength,
            MinimumLength = HouseTitleMinLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(HouseAddressMaxLength
            ,MinimumLength = HouseAddressMinLength)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [StringLength(HouseDescMaxLength,
            MinimumLength = HouseDescMinLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [DisplayName("Image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Range(typeof(decimal),
            HousePricePerMonthMin, 
            HousePricePerMonthMax, 
            ErrorMessage = PriceRangeErrorMessage,
            ParseLimitsInInvariantCulture = true)]
        public decimal PricePerMonth { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<HouseCategoryServiceModel> Categories { get; set; } 
            = new List<HouseCategoryServiceModel>();
    }
}
