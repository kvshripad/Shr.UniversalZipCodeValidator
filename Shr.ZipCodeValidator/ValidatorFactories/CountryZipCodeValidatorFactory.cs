using System.Linq;
using System;
using System.Collections.Generic;
using Shr.ZipCodeValidator.CountryValidators;
using Shr.ZipCodeValidator.Common;

namespace Shr.ZipCodeValidator.ValidatorFactories
{
    internal class CountryZipCodeValidatorFactory : IValidatorFactory<ICountryZipCodeValidator, CountryCode>
    {
        private List<ICountryZipCodeValidator> _countryValidators;

        public ICountryZipCodeValidator GetValidator(CountryCode countryCode)
        {
            if (null == _countryValidators || !_countryValidators.Any(x => x.Code == countryCode))
                throw new Exception("ZipCodeValidator country list empty or country not configured!");

            return _countryValidators.First(x => x.Code == countryCode);
        }

        public CountryZipCodeValidatorFactory(List<ICountryZipCodeValidator> countryValidators)
        {
            this._countryValidators = countryValidators;
        }
    }
}