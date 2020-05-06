using EC.VL.MSQ.Common.ZipCodeValidator.CountryValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.VL.MSQ.Common.ZipCodeValidator
{
    public class ZipValidator
    {
        private static List<IZipCodeValidator> _countryValidators;

        static ZipValidator()
        {
            InitializeValidators();
        }

        private static void InitializeValidators()
        {
            _countryValidators = new List<IZipCodeValidator>();

            _countryValidators
                .AddRange(
                    new List<IZipCodeValidator>
                    {
                        new USZipCodeValidator(),
                        new INZipCodeValidator()
                    });
        }

        public static bool Validate(CountryCode countryCode, string zipCode)
        {
            if (null == _countryValidators || !_countryValidators.Any())
                throw new Exception("Country ZipCode validators not available!");

            bool result = false;

            foreach (var validator in _countryValidators)
            {
                result = result || validator.Validate(countryCode, zipCode);
            }

            return result;
        }
    }
}
