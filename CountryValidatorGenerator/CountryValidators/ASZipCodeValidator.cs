using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class ASZipCodeValidator : BaseZipCodeValidator
    {
        public ASZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.AS;
            this.ZipCodePatterns = new List<string>
            {
                @"^96799$"
            };
        }
    }
}
