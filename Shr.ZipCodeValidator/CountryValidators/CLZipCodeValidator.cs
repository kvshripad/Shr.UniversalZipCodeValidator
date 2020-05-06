using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class CLZipCodeValidator : BaseZipCodeValidator
    {
        public CLZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.CL;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{7}$"
            };
        }
    }
}
