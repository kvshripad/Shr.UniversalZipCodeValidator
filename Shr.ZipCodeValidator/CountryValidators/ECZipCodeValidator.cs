using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class ECZipCodeValidator : BaseZipCodeValidator
    {
        public ECZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.EC;
            this.ZipCodePatterns = new List<string>
            {
                @"^([A-Z]\d{4}[A-Z]|(?:[A-Z]{2})?\d{6})?$"
            };
        }
    }
}
