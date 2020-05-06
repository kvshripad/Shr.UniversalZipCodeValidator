using System;
using System.Text.RegularExpressions;

namespace EC.VL.MSQ.Common.ZipCodeValidator.CountryValidators
{
    internal class USZipCodeValidator : IZipCodeValidator
    {
        private readonly CountryCode _code = CountryCode.US;
        private readonly string regexUSPattern = "^[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9]$";

        public bool Validate(CountryCode countryCode, string zipCode)
        {
            if (countryCode != this._code) return false;

            bool result = false;
            // Validate US zip code
            if (Regex.IsMatch(zipCode, this.regexUSPattern))
                result = true;

            return result;
        }
    }
}