using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class JPZipCodeValidator : BaseZipCodeValidator
    {
        public JPZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.JP;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}-\d{4}$"
            };
        }
    }
}
