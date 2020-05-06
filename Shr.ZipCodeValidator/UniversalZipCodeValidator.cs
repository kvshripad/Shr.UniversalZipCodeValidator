using Shr.ZipCodeValidator.Common;
using Shr.ZipCodeValidator.CountryValidators;
using Shr.ZipCodeValidator.ValidatorFactories;
using Shr.ZipCodeValidator.ValidatorStrategies;
using System.Collections.Generic;

namespace Shr.ZipCodeValidator
{
    public class UniversalZipCodeValidator
    {
        private static readonly IValidatorFactory<ICountryZipCodeValidator, CountryCode> _factory;
        private static readonly IValidatorStrategy<List<string>, string> _matchAnyStrategy;

        /// <summary>
        /// Gets a validator for the Country and validates the ZipCode according to configured rules
        /// </summary>
        /// <param name="countryCode"></param>
        /// <param name="zipCode"></param>
        /// <returns></returns>
        public static bool Validate(CountryCode countryCode, string zipCode)
        {
            return _factory.GetValidator(countryCode).Validate(zipCode);
        }

        /// <summary>
        /// Initializes static properties of the class
        /// </summary>
        static UniversalZipCodeValidator()
        {
            // Initialize strategy
            _matchAnyStrategy = new RegexValidatorStrategy();

            // Initialize Validator factory
            _factory = new CountryZipCodeValidatorFactory(
                                new List<ICountryZipCodeValidator>
                                {
                                    new ADZipCodeValidator(_matchAnyStrategy),
                                    new AMZipCodeValidator(_matchAnyStrategy),
                                    new ARZipCodeValidator(_matchAnyStrategy),
                                    new ASZipCodeValidator(_matchAnyStrategy),
                                    new ATZipCodeValidator(_matchAnyStrategy),
                                    new AUZipCodeValidator(_matchAnyStrategy),
                                    new AXZipCodeValidator(_matchAnyStrategy),
                                    new AZZipCodeValidator(_matchAnyStrategy),
                                    new BAZipCodeValidator(_matchAnyStrategy),
                                    new BBZipCodeValidator(_matchAnyStrategy),
                                    new BDZipCodeValidator(_matchAnyStrategy),
                                    new BEZipCodeValidator(_matchAnyStrategy),
                                    new BGZipCodeValidator(_matchAnyStrategy),
                                    new BHZipCodeValidator(_matchAnyStrategy),
                                    new BMZipCodeValidator(_matchAnyStrategy),
                                    new BNZipCodeValidator(_matchAnyStrategy),
                                    new BRZipCodeValidator(_matchAnyStrategy),
                                    new BYZipCodeValidator(_matchAnyStrategy),
                                    new CAZipCodeValidator(_matchAnyStrategy),
                                    new CCZipCodeValidator(_matchAnyStrategy),
                                    new CHZipCodeValidator(_matchAnyStrategy),
                                    new CKZipCodeValidator(_matchAnyStrategy),
                                    new CLZipCodeValidator(_matchAnyStrategy),
                                    new CNZipCodeValidator(_matchAnyStrategy),
                                    new CRZipCodeValidator(_matchAnyStrategy),
                                    new CSZipCodeValidator(_matchAnyStrategy),
                                    new CVZipCodeValidator(_matchAnyStrategy),
                                    new CXZipCodeValidator(_matchAnyStrategy),
                                    new CYZipCodeValidator(_matchAnyStrategy),
                                    new CZZipCodeValidator(_matchAnyStrategy),
                                    new DEZipCodeValidator(_matchAnyStrategy),
                                    new DKZipCodeValidator(_matchAnyStrategy),
                                    new DOZipCodeValidator(_matchAnyStrategy),
                                    new DZZipCodeValidator(_matchAnyStrategy),
                                    new ECZipCodeValidator(_matchAnyStrategy),
                                    new EEZipCodeValidator(_matchAnyStrategy),
                                    new EGZipCodeValidator(_matchAnyStrategy),
                                    new ESZipCodeValidator(_matchAnyStrategy),
                                    new ETZipCodeValidator(_matchAnyStrategy),
                                    new FIZipCodeValidator(_matchAnyStrategy),
                                    new FKZipCodeValidator(_matchAnyStrategy),
                                    new FMZipCodeValidator(_matchAnyStrategy),
                                    new FOZipCodeValidator(_matchAnyStrategy),
                                    new FRZipCodeValidator(_matchAnyStrategy),
                                    new GBZipCodeValidator(_matchAnyStrategy),
                                    new GEZipCodeValidator(_matchAnyStrategy),
                                    new GFZipCodeValidator(_matchAnyStrategy),
                                    new GGZipCodeValidator(_matchAnyStrategy),
                                    new GLZipCodeValidator(_matchAnyStrategy),
                                    new GNZipCodeValidator(_matchAnyStrategy),
                                    new GPZipCodeValidator(_matchAnyStrategy),
                                    new GRZipCodeValidator(_matchAnyStrategy),
                                    new GSZipCodeValidator(_matchAnyStrategy),
                                    new GTZipCodeValidator(_matchAnyStrategy),
                                    new GUZipCodeValidator(_matchAnyStrategy),
                                    new GWZipCodeValidator(_matchAnyStrategy),
                                    new HMZipCodeValidator(_matchAnyStrategy),
                                    new HNZipCodeValidator(_matchAnyStrategy),
                                    new HRZipCodeValidator(_matchAnyStrategy),
                                    new HTZipCodeValidator(_matchAnyStrategy),
                                    new HUZipCodeValidator(_matchAnyStrategy),
                                    new IDZipCodeValidator(_matchAnyStrategy),
                                    new ILZipCodeValidator(_matchAnyStrategy),
                                    new IMZipCodeValidator(_matchAnyStrategy),
                                    new INZipCodeValidator(_matchAnyStrategy),
                                    new IOZipCodeValidator(_matchAnyStrategy),
                                    new IQZipCodeValidator(_matchAnyStrategy),
                                    new ISZipCodeValidator(_matchAnyStrategy),
                                    new ITZipCodeValidator(_matchAnyStrategy),
                                    new JEZipCodeValidator(_matchAnyStrategy),
                                    new JOZipCodeValidator(_matchAnyStrategy),
                                    new JPZipCodeValidator(_matchAnyStrategy),
                                    new KEZipCodeValidator(_matchAnyStrategy),
                                    new KGZipCodeValidator(_matchAnyStrategy),
                                    new KHZipCodeValidator(_matchAnyStrategy),
                                    new KRZipCodeValidator(_matchAnyStrategy),
                                    new KWZipCodeValidator(_matchAnyStrategy),
                                    new KZZipCodeValidator(_matchAnyStrategy),
                                    new LAZipCodeValidator(_matchAnyStrategy),
                                    new LBZipCodeValidator(_matchAnyStrategy),
                                    new LIZipCodeValidator(_matchAnyStrategy),
                                    new LKZipCodeValidator(_matchAnyStrategy),
                                    new LRZipCodeValidator(_matchAnyStrategy),
                                    new LSZipCodeValidator(_matchAnyStrategy),
                                    new LTZipCodeValidator(_matchAnyStrategy),
                                    new LUZipCodeValidator(_matchAnyStrategy),
                                    new LVZipCodeValidator(_matchAnyStrategy),
                                    new MAZipCodeValidator(_matchAnyStrategy),
                                    new MCZipCodeValidator(_matchAnyStrategy),
                                    new MDZipCodeValidator(_matchAnyStrategy),
                                    new MEZipCodeValidator(_matchAnyStrategy),
                                    new MGZipCodeValidator(_matchAnyStrategy),
                                    new MHZipCodeValidator(_matchAnyStrategy),
                                    new MKZipCodeValidator(_matchAnyStrategy),
                                    new MNZipCodeValidator(_matchAnyStrategy),
                                    new MPZipCodeValidator(_matchAnyStrategy),
                                    new MQZipCodeValidator(_matchAnyStrategy),
                                    new MTZipCodeValidator(_matchAnyStrategy),
                                    new MUZipCodeValidator(_matchAnyStrategy),
                                    new MVZipCodeValidator(_matchAnyStrategy),
                                    new MXZipCodeValidator(_matchAnyStrategy),
                                    new MYZipCodeValidator(_matchAnyStrategy),
                                    new NCZipCodeValidator(_matchAnyStrategy),
                                    new NEZipCodeValidator(_matchAnyStrategy),
                                    new NFZipCodeValidator(_matchAnyStrategy),
                                    new NGZipCodeValidator(_matchAnyStrategy),
                                    new NIZipCodeValidator(_matchAnyStrategy),
                                    new NLZipCodeValidator(_matchAnyStrategy),
                                    new NOZipCodeValidator(_matchAnyStrategy),
                                    new NPZipCodeValidator(_matchAnyStrategy),
                                    new NZZipCodeValidator(_matchAnyStrategy),
                                    new OMZipCodeValidator(_matchAnyStrategy),
                                    new PFZipCodeValidator(_matchAnyStrategy),
                                    new PGZipCodeValidator(_matchAnyStrategy),
                                    new PHZipCodeValidator(_matchAnyStrategy),
                                    new PKZipCodeValidator(_matchAnyStrategy),
                                    new PLZipCodeValidator(_matchAnyStrategy),
                                    new PMZipCodeValidator(_matchAnyStrategy),
                                    new PNZipCodeValidator(_matchAnyStrategy),
                                    new PRZipCodeValidator(_matchAnyStrategy),
                                    new PTZipCodeValidator(_matchAnyStrategy),
                                    new PWZipCodeValidator(_matchAnyStrategy),
                                    new PYZipCodeValidator(_matchAnyStrategy),
                                    new REZipCodeValidator(_matchAnyStrategy),
                                    new ROZipCodeValidator(_matchAnyStrategy),
                                    new RSZipCodeValidator(_matchAnyStrategy),
                                    new RUZipCodeValidator(_matchAnyStrategy),
                                    new SAZipCodeValidator(_matchAnyStrategy),
                                    new SEZipCodeValidator(_matchAnyStrategy),
                                    new SGZipCodeValidator(_matchAnyStrategy),
                                    new SHZipCodeValidator(_matchAnyStrategy),
                                    new SIZipCodeValidator(_matchAnyStrategy),
                                    new SJZipCodeValidator(_matchAnyStrategy),
                                    new SKZipCodeValidator(_matchAnyStrategy),
                                    new SMZipCodeValidator(_matchAnyStrategy),
                                    new SNZipCodeValidator(_matchAnyStrategy),
                                    new SOZipCodeValidator(_matchAnyStrategy),
                                    new SZZipCodeValidator(_matchAnyStrategy),
                                    new TCZipCodeValidator(_matchAnyStrategy),
                                    new THZipCodeValidator(_matchAnyStrategy),
                                    new TJZipCodeValidator(_matchAnyStrategy),
                                    new TMZipCodeValidator(_matchAnyStrategy),
                                    new TNZipCodeValidator(_matchAnyStrategy),
                                    new TRZipCodeValidator(_matchAnyStrategy),
                                    new TWZipCodeValidator(_matchAnyStrategy),
                                    new UAZipCodeValidator(_matchAnyStrategy),
                                    new USZipCodeValidator(_matchAnyStrategy),
                                    new UYZipCodeValidator(_matchAnyStrategy),
                                    new UZZipCodeValidator(_matchAnyStrategy),
                                    new VAZipCodeValidator(_matchAnyStrategy),
                                    new VEZipCodeValidator(_matchAnyStrategy),
                                    new VIZipCodeValidator(_matchAnyStrategy),
                                    new WFZipCodeValidator(_matchAnyStrategy),
                                    new XKZipCodeValidator(_matchAnyStrategy),
                                    new YTZipCodeValidator(_matchAnyStrategy),
                                    new YUZipCodeValidator(_matchAnyStrategy),
                                    new ZAZipCodeValidator(_matchAnyStrategy),
                                    new ZMZipCodeValidator(_matchAnyStrategy)
                                });
        }
    }
}
