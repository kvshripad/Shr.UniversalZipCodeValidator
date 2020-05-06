using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class CZZipCodeValidator : BaseZipCodeValidator
    {
        public CZZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.CZ;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}[ ]?\d{2}$"
            };
        }
    }
}
