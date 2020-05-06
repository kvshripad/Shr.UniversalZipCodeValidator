using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class MTZipCodeValidator : BaseZipCodeValidator
    {
        public MTZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.MT;
            this.ZipCodePatterns = new List<string>
            {
                @"^[A-Z]{3}[ ]?\d{2,4}$"
            };
        }
    }
}
