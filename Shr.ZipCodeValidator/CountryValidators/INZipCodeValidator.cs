using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class INZipCodeValidator : BaseZipCodeValidator
    {
        public INZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.IN;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{6}$"
            };
        }
    }
}
