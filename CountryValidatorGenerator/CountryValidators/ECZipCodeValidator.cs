using EC.VL.SHARED.ZipCodeValidator.Common;
using EC.VL.SHARED.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace EC.VL.SHARED.ZipCodeValidator.CountryValidators
{
    internal class ECZipCodeValidator : BaseZipCodeValidator
    {
        public ECZipCodeValidator(IValidatorStrategy strategy) : base(strategy)
        {
            this.Code = CountryCode.EC;
            this.ZipCodePatterns = new List<string>
            {
                @"^([A-Z]\d{4}[A-Z]|(?:[A-Z]{2})?\d{6})?$"
            };
        }
    }
}
