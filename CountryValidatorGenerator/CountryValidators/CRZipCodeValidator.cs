using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class CRZipCodeValidator : BaseZipCodeValidator
    {
        public CRZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.CR;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{4,5}|\d{3}-\d{4}$"
            };
        }
    }
}
