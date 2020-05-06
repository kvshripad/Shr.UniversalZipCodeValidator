using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class KHZipCodeValidator : BaseZipCodeValidator
    {
        public KHZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.KH;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{5}$"
            };
        }
    }
}
