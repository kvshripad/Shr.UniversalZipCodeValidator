using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class GGZipCodeValidator : BaseZipCodeValidator
    {
        public GGZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.GG;
            this.ZipCodePatterns = new List<string>
            {
                @"^GY\d[\dA-Z]?[ ]?\d[ABD-HJLN-UW-Z]{2}$"
            };
        }
    }
}
