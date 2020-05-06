using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class PFZipCodeValidator : BaseZipCodeValidator
    {
        public PFZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.PF;
            this.ZipCodePatterns = new List<string>
            {
                @"^987\d{2}$"
            };
        }
    }
}
