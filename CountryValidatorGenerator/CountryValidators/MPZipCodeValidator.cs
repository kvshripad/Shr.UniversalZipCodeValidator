using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class MPZipCodeValidator : BaseZipCodeValidator
    {
        public MPZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.MP;
            this.ZipCodePatterns = new List<string>
            {
                @"^9695[012]([ \-]\d{4})?$"
            };
        }
    }
}
