using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class BMZipCodeValidator : BaseZipCodeValidator
    {
        public BMZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.BM;
            this.ZipCodePatterns = new List<string>
            {
                @"^[A-Z]{2}[ ]?[A-Z0-9]{2}$"
            };
        }
    }
}
