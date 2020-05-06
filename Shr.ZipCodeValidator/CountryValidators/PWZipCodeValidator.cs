using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class PWZipCodeValidator : BaseZipCodeValidator
    {
        public PWZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.PW;
            this.ZipCodePatterns = new List<string>
            {
                @"^96940$"
            };
        }
    }
}
