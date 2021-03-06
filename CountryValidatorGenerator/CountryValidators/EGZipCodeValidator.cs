using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class EGZipCodeValidator : BaseZipCodeValidator
    {
        public EGZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.EG;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{5}$"
            };
        }
    }
}
