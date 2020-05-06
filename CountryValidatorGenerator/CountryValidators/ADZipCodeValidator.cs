using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class ADZipCodeValidator : BaseZipCodeValidator
    {
        public ADZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.AD;
            this.ZipCodePatterns = new List<string>
            {
                @"^AD\d{3}$"
            };
        }
    }
}
