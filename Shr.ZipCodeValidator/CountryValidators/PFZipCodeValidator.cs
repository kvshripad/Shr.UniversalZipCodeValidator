using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class PFZipCodeValidator : BaseZipCodeValidator
    {
        public PFZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.PF;
            this.ZipCodePatterns = new List<string>
            {
                @"^987\d{2}$"
            };
        }
    }
}
