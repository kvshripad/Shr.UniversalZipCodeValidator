using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class BBZipCodeValidator : BaseZipCodeValidator
    {
        public BBZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.BB;
            this.ZipCodePatterns = new List<string>
            {
                @"^(BB\d{5})?$"
            };
        }
    }
}
