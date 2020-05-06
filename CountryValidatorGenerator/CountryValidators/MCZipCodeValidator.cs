using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class MCZipCodeValidator : BaseZipCodeValidator
    {
        public MCZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.MC;
            this.ZipCodePatterns = new List<string>
            {
                @"^980\d{2}$"
            };
        }
    }
}
