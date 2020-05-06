using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class MQZipCodeValidator : BaseZipCodeValidator
    {
        public MQZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.MQ;
            this.ZipCodePatterns = new List<string>
            {
                @"^9[78]2\d{2}$"
            };
        }
    }
}
