using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class MEZipCodeValidator : BaseZipCodeValidator
    {
        public MEZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.ME;
            this.ZipCodePatterns = new List<string>
            {
                @"^8\d{4}$"
            };
        }
    }
}
