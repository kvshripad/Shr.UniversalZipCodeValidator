using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class NLZipCodeValidator : BaseZipCodeValidator
    {
        public NLZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.NL;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{4}[ ]?[A-Z]{2}$"
            };
        }
    }
}
