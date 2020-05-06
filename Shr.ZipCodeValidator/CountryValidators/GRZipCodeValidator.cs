using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class GRZipCodeValidator : BaseZipCodeValidator
    {
        public GRZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.GR;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}[ ]?\d{2}$"
            };
        }
    }
}
