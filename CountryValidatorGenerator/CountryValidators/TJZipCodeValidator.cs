using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class TJZipCodeValidator : BaseZipCodeValidator
    {
        public TJZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.TJ;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{6}$"
            };
        }
    }
}
