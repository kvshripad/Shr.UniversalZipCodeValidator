using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class NFZipCodeValidator : BaseZipCodeValidator
    {
        public NFZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.NF;
            this.ZipCodePatterns = new List<string>
            {
                @"^2899$"
            };
        }
    }
}
