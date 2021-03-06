using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class BYZipCodeValidator : BaseZipCodeValidator
    {
        public BYZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.BY;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{6}$"
            };
        }
    }
}
