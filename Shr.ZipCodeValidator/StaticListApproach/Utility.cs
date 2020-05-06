using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.VL.SHARED.ZipCodeValidator.StaticListApproach
{
    internal static class Utility
    {
        internal static List<string> GetPatterns(string countryCode)
        {
            var result = Utility.CountryPatters.ContainsKey(countryCode)
                            ? Utility.CountryPatters[countryCode]
                            : new List<string>();
            return result;
        }

        internal static IDictionary<string, List<string>> CountryPatters =
            new Dictionary<string, List<string>>
            {
                {
                    "US", new List<string>
                    {
                        "^[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9]$",
                        "^[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]$"
                    }
                },
                {
                    "IN",
                    new List<string>
                    {
                        "^[0-9][0-9][0-9][0-9][0-9][0-9]$"
                    }
                }
            };
    }
}
