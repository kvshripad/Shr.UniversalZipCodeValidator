using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class CLZipCodeValidator : BaseZipCodeValidator
    {
        public CLZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.CL;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{7}$"
            };
        }
    }
}
