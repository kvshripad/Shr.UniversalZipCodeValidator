using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class NCZipCodeValidator : BaseZipCodeValidator
    {
        public NCZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.NC;
            this.ZipCodePatterns = new List<string>
            {
                @"^988\d{2}$"
            };
        }
    }
}
