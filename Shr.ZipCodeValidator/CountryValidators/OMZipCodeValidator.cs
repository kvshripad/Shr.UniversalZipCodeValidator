using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class OMZipCodeValidator : BaseZipCodeValidator
    {
        public OMZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.OM;
            this.ZipCodePatterns = new List<string>
            {
                @"^(PC )?\d{3}$"
            };
        }
    }
}
