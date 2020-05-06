using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class PWZipCodeValidator : BaseZipCodeValidator
    {
        public PWZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.PW;
            this.ZipCodePatterns = new List<string>
            {
                @"^96940$"
            };
        }
    }
}
