using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies; 
using System.Collections.Generic; 

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal class MHZipCodeValidator : BaseZipCodeValidator
    {
        public MHZipCodeValidator(IValidatorStrategy<List<string>, string>  strategy) : base(strategy)
        {
            this.Code = CountryCode.MH;
            this.ZipCodePatterns = new List<string>
            {
                @"^969[67]\d([ \-]\d{4})?$"
            };
        }
    }
}
