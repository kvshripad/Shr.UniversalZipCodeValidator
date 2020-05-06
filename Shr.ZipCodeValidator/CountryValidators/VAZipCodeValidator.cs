using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class VAZipCodeValidator : BaseZipCodeValidator
    {
        public VAZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.VA;
            this.ZipCodePatterns = new List<string>
            {
                @"^00120$"
            };
        }
    }
}
