using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class IMZipCodeValidator : BaseZipCodeValidator
    {
        public IMZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.IM;
            this.ZipCodePatterns = new List<string>
            {
                @"^IM\d[\dA-Z]?[ ]?\d[ABD-HJLN-UW-Z]{2}$"
            };
        }
    }
}
