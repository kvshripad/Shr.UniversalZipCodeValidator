using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class CXZipCodeValidator : BaseZipCodeValidator
    {
        public CXZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.CX;
            this.ZipCodePatterns = new List<string>
            {
                @"^6798$"
            };
        }
    }
}
