using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class FOZipCodeValidator : BaseZipCodeValidator
    {
        public FOZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.FO;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}$"
            };
        }
    }
}
