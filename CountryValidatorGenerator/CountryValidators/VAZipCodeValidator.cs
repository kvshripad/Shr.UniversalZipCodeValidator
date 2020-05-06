using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class VAZipCodeValidator : BaseZipCodeValidator
    {
        public VAZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.VA;
            this.ZipCodePatterns = new List<string>
            {
                @"^00120$"
            };
        }
    }
}
