using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.VL.QUOT.UniversalValidator
{
    public interface IValidatorStrategy
    {
        bool Validate(string input);
    }
}
