using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class ASZipCodeValidator : BaseZipCodeValidator
    {
        public ASZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.AS;
            this.ZipCodePatterns = new List<string>
            {
                @"^96799$"
            };
        }
    }
}
