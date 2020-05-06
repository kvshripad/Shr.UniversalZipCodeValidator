using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class GLZipCodeValidator : BaseZipCodeValidator
    {
        public GLZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.GL;
            this.ZipCodePatterns = new List<string>
            {
                @"^39\d{2}$"
            };
        }
    }
}
