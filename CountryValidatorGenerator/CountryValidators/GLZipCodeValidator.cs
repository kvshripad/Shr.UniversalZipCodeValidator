using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class GLZipCodeValidator : BaseZipCodeValidator
    {
        public GLZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.GL;
            this.ZipCodePatterns = new List<string>
            {
                @"^39\d{2}$"
            };
        }
    }
}
