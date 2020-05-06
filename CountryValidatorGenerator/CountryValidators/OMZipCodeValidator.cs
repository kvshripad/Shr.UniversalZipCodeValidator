using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class OMZipCodeValidator : BaseZipCodeValidator
    {
        public OMZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.OM;
            this.ZipCodePatterns = new List<string>
            {
                @"^(PC )?\d{3}$"
            };
        }
    }
}
