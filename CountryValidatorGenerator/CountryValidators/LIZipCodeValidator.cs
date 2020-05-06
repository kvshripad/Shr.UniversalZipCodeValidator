using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class LIZipCodeValidator : BaseZipCodeValidator
    {
        public LIZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.LI;
            this.ZipCodePatterns = new List<string>
            {
                @"^(948[5-9])|(949[0-7])$"
            };
        }
    }
}
