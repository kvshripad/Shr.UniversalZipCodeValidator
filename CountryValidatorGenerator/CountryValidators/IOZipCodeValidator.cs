using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class IOZipCodeValidator : BaseZipCodeValidator
    {
        public IOZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.IO;
            this.ZipCodePatterns = new List<string>
            {
                @"^BBND 1ZZ$"
            };
        }
    }
}
