using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class HTZipCodeValidator : BaseZipCodeValidator
    {
        public HTZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.HT;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{4}$"
            };
        }
    }
}
