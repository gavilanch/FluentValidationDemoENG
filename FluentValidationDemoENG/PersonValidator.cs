using FluentValidation;

namespace FluentValidationDemoENG
{
    public class PersonValidator: AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Name).NotEmpty();

            RuleFor(x => x.Email).EmailAddress();

            RuleFor(x => x.Age).InclusiveBetween(18, 150);

            RuleFor(x => x.InitialDate).Must((person, _) =>
            {
                return person.InitialDate < person.EndDate;
            }).WithMessage("The initial date should come before the end date");
        }
    }
}
