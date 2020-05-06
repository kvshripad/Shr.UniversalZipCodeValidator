using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class CXZipCodeValidator : BaseZipCodeValidator
    {
        public CXZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.CX;
            this.ZipCodePatterns = new List<string>
            {
                @"^6798$"
            };
        }
    }
}
