using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class ETZipCodeValidator : BaseZipCodeValidator
    {
        public ETZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.ET;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{4}$"
            };
        }
    }
}
