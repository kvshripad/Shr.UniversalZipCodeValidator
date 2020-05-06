using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class NIZipCodeValidator : BaseZipCodeValidator
    {
        public NIZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.NI;
            this.ZipCodePatterns = new List<string>
            {
                @"^((\d{4}-)?\d{3}-\d{3}(-\d{1})?)?$"
            };
        }
    }
}
