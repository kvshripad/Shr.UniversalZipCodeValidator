using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class NLZipCodeValidator : BaseZipCodeValidator
    {
        public NLZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.NL;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{4}[ ]?[A-Z]{2}$"
            };
        }
    }
}
