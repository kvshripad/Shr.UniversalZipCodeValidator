using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class GUZipCodeValidator : BaseZipCodeValidator
    {
        public GUZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.GU;
            this.ZipCodePatterns = new List<string>
            {
                @"^969[123]\d([ \-]\d{4})?$"
            };
        }
    }
}
