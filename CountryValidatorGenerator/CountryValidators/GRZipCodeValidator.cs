using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class GRZipCodeValidator : BaseZipCodeValidator
    {
        public GRZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.GR;
            this.ZipCodePatterns = new List<string>
            {
                @"^\d{3}[ ]?\d{2}$"
            };
        }
    }
}
