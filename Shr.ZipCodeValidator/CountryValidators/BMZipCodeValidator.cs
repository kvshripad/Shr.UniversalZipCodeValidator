using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class BMZipCodeValidator : BaseZipCodeValidator
    {
        public BMZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.BM;
            this.ZipCodePatterns = new List<string>
            {
                @"^[A-Z]{2}[ ]?[A-Z0-9]{2}$"
            };
        }
    }
}
