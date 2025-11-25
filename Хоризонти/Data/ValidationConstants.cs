namespace Horizons.Data
{
    public static class ValidationConstants
    {
        public const int DestinationNameMinimumLength = 3;
        public const int DestinationNameMaximumLength = 80;

        public const int DestinationDescriptionMinimumLength = 10;
        public const int DestinationDescriptionMaximumLength = 250;

        //public const string DateFormat = "yyyy-MM-dd";

        public const int TerrainNameMinimumLength = 3;
        public const int TerrainNameMaximumLength = 20;

        public const string RequireErrorMessage = "The field {0} is required";
        public const string StringLengthErrorMessage = "The field {0} must be between {2} and {1} characters long";
    }
}
