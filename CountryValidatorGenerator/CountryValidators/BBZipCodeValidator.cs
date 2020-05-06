using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class BBZipCodeValidator : BaseZipCodeValidator
    {
        public BBZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.BB;
            this.ZipCodePatterns = new List<string>
            {
                @"^(BB\d{5})?$"
            };
        }
    }
}
