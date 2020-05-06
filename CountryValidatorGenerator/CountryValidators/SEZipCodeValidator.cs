using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class SEZipCodeValidator : BaseZipCodeValidator
    {
        public SEZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.SE;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}[ ]?\d{2}$"
            };
        }
    }
}
