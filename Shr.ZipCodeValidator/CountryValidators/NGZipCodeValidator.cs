using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class NGZipCodeValidator : BaseZipCodeValidator
    {
        public NGZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.NG;
            this.ZipCodePatterns = new List<string>
            {
                @"^(\d{6})?$"
            };
        }
    }
}
