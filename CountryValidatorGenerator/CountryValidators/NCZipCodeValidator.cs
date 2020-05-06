using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class NCZipCodeValidator : BaseZipCodeValidator
    {
        public NCZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.NC;
            this.ZipCodePatterns = new List<string>
            {
                @"^988\d{2}$"
            };
        }
    }
}
