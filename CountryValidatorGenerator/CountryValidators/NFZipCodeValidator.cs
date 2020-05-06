using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class NFZipCodeValidator : BaseZipCodeValidator
    {
        public NFZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.NF;
            this.ZipCodePatterns = new List<string>
            {
                @"^2899$"
            };
        }
    }
}
