using System;
using System.Text.RegularExpressions;

namespace EC.VL.MSQ.Common.ZipCodeValidator.CountryValidators
{
    internal class INZipCodeValidator : IZipCodeValidator
    {
        private CountryCode _code = CountryCode.IN;
        private string regexINPattern = "^[1-9][0-9][0-9][0-9][0-9][0-9]$";

        public bool Validate(CountryCode countryCode, string zipCode)
        {
            if (countryCode != this._code) return false;

            bool result = false;
            // Validate Indian zip code
            if (Regex.IsMatch(zipCode, this.regexINPattern))
                result = true;

            return result;
        }
    }
}