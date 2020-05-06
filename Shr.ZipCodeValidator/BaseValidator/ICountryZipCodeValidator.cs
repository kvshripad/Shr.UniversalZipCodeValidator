using Shr.ZipCodeValidator.Common;

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal interface ICountryZipCodeValidator
    {
        CountryCode Code { get; set; }
        bool Validate(string zipCode);
    }
}
