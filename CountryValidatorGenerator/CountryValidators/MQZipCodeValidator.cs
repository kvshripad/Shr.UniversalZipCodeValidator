using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class MQZipCodeValidator : BaseZipCodeValidator
    {
        public MQZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.MQ;
            this.ZipCodePatterns = new List<string>
            {
                @"^9[78]2\d{2}$"
            };
        }
    }
}
