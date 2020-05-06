using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class GFZipCodeValidator : BaseZipCodeValidator
    {
        public GFZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.GF;
            this.ZipCodePatterns = new List<string>
            {
                @"^9[78]3\d{2}$"
            };
        }
    }
}
