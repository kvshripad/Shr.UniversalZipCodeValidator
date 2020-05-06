using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.ValidatorStrategies;
using System;
using System.Collections.Generic;

namespace Shr.ZipCodeValidator.CountryValidators
{
    internal abstract class BaseZipCodeValidator : ICountryZipCodeValidator
    {
        private readonly IValidatorStrategy<List<string>, string> _validatorStrategy;
        protected virtual List<string> ZipCodePatterns { get; set; }
        public virtual CountryCode Code { get; set; }

        /// <summary>
        /// Initializes ZipCode Validator with a validation strategy
        /// </summary>
        /// <param name="strategy">Instance of IValidatorStrategy</param>
        public BaseZipCodeValidator(IValidatorStrategy<List<string>, string> strategy)
        {
            this._validatorStrategy = strategy ?? throw new Exception("Null or Invalid Strategy.");
        }

        /// <summary>
        /// Validate zip code as per initialized validation strategy.
        /// </summary>
        /// <param name="zipCode"></param>
        /// <returns></returns>
        public virtual bool Validate(string zipCode)
        {
            return this._validatorStrategy.Validate(this.ZipCodePatterns, zipCode);
        }
    }
}
