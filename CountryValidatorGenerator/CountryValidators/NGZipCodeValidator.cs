using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class NGZipCodeValidator : BaseZipCodeValidator
    {
        public NGZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.NG;
            this.ZipCodePatterns = new List<string>
            {
                @"^(\d{6})?$"
            };
        }
    }
}
