using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class MTZipCodeValidator : BaseZipCodeValidator
    {
        public MTZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.MT;
            this.ZipCodePatterns = new List<string>
            {
                @"^[A-Z]{3}[ ]?\d{2,4}$"
            };
        }
    }
}
