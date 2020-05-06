using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class PMZipCodeValidator : BaseZipCodeValidator
    {
        public PMZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.PM;
            this.ZipCodePatterns = new List<string>
            {
                @"^9[78]5\d{2}$"
            };
        }
    }
}
