using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class USZipCodeValidator : BaseZipCodeValidator
    {
        public USZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.US;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{5}([ \-]\d{4})?$"
            };
        }
    }
}
