using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class JPZipCodeValidator : BaseZipCodeValidator
    {
        public JPZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.JP;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}-\d{4}$"
            };
        }
    }
}
