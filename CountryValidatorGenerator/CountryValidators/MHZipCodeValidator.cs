using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class MHZipCodeValidator : BaseZipCodeValidator
    {
        public MHZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.MH;
            this.ZipCodePatterns = new List<string>
            {
                @"^969[67]\d([ \-]\d{4})?$"
            };
        }
    }
}
