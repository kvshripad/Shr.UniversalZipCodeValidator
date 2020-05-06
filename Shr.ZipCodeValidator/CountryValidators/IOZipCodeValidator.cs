using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class IOZipCodeValidator : BaseZipCodeValidator
    {
        public IOZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.IO;
            this.ZipCodePatterns = new List<string>
            {
                @"^BBND 1ZZ$"
            };
        }
    }
}
