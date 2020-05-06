using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class LIZipCodeValidator : BaseZipCodeValidator
    {
        public LIZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.LI;
            this.ZipCodePatterns = new List<string>
            {
                @"^(948[5-9])|(949[0-7])$"
            };
        }
    }
}
