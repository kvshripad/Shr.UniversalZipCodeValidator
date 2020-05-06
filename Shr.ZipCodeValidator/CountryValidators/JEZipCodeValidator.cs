using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class JEZipCodeValidator : BaseZipCodeValidator
    {
        public JEZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.JE;
            this.ZipCodePatterns = new List<string>
            {
                @"^JE\d[\dA-Z]?[ ]?\d[ABD-HJLN-UW-Z]{2}$"
            };
        }
    }
}
