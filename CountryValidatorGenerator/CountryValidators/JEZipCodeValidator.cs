using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class JEZipCodeValidator : BaseZipCodeValidator
    {
        public JEZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.JE;
            this.ZipCodePatterns = new List<string>
            {
                @"^JE\d[\dA-Z]?[ ]?\d[ABD-HJLN-UW-Z]{2}$"
            };
        }
    }
}
