using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class MUZipCodeValidator : BaseZipCodeValidator
    {
        public MUZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.MU;
            this.ZipCodePatterns = new List<string>
            {
                @"^(\d{3}[A-Z]{2}\d{3})?$"
            };
        }
    }
}
