namespace HouseRentingSystem.Core.Constants
{
    public static class ErrorMessages
    {
        public const string RequiredErrorMessage = "The {0} field is required.";
        public const string InvalidLengthErrorMessage = "The {0} field must be between {2} and {1} characters long.";
        public const string PhoneExistsErrorMessage = "An agent with this phone number already exists.";
        public const string UserHasRentsErrorMessage = "The user has existing rents.";
    }
}
