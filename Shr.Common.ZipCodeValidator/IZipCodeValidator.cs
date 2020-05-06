using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.VL.MSQ.Common.ZipCodeValidator
{
    public interface IZipCodeValidator
    {
        bool Validate(CountryCode countryCode, string zipCode);
    }
}
