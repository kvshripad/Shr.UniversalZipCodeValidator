using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class HMZipCodeValidator : BaseZipCodeValidator
    {
        public HMZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.HM;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{4}$"
            };
        }
    }
}
