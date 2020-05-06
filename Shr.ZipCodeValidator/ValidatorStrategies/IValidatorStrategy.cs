using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shr.ZipCodeValidator.ValidatorStrategies
{
    internal interface IValidatorStrategy<T,I>
    {
        bool Validate(T HelperData, I Input);
    }
}
