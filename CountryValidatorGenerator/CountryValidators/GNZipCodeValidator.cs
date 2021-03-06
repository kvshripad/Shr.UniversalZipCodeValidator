using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class GNZipCodeValidator : BaseZipCodeValidator
    {
        public GNZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.GN;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}$"
            };
        }
    }
}
