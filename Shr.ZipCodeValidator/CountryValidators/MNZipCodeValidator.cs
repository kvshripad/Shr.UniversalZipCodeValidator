using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class MNZipCodeValidator : BaseZipCodeValidator
    {
        public MNZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.MN;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{6}$"
            };
        }
    }
}
