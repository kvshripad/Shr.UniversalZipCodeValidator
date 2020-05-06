namespace Shr.ZipCodeValidator.ValidatorFactories
{
    internal interface IValidatorFactory<T, C>
    {
        T GetValidator(C constraint);
    }
}
